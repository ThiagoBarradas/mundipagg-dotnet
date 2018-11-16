using Mundipagg.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Mundipagg.Utils
{
    /// <summary>
    /// Http client utility
    /// </summary>
    internal class HttpClientUtil : IHttpClientUtil
    {
        #region Public Constructors

        /// <summary>
        /// Creates a new http client utility
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        /// <param name="jsonSerializerSettings">Json serializer settings</param>
        public HttpClientUtil(Configuration configuration, JsonSerializerSettings jsonSerializerSettings)
        {
            this.Configuration = configuration;
            this.JsonSerializerSettings = jsonSerializerSettings;
            this.Client = new HttpClient();
            this.Client.DefaultRequestHeaders.Accept.Clear();
            this.Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.Client.DefaultRequestHeaders.Add("User-Agent", "Mundipagg Dotnet SDK");
            this.Client.Timeout = TimeSpan.FromMilliseconds(configuration.Timeout);
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Native HttpClient
        /// </summary>
        private HttpClient Client { get; set; }

        /// <summary>
        /// Mundipagg Api Client Configuration
        /// </summary>
        private Configuration Configuration { get; set; }

        /// <summary>
        /// Json serialize settings
        /// </summary>
        private JsonSerializerSettings JsonSerializerSettings { get; set; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        /// Send request and mount response to client format
        /// </summary>
        /// <typeparam name="T">Response type</typeparam>
        /// <param name="method">Method to call</param>
        /// <param name="endpoint">Endpoint to call</param>
        /// <param name="body">Body object</param>
        /// <param name="query">Params to mount query string</param>
        /// <returns>Base response with specific data defined in T</returns>
        public BaseResponse<T> SendRequest<T>(HttpMethod method, string endpoint, object body, IDictionary<string, string> query = null)
        {
            BaseResponse<T> response = new BaseResponse<T>();
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                var fullUri = this.GetFullUri(endpoint, query);
                var request = new HttpRequestMessage(method, fullUri);

                if (body != null && method.Method.ToUpper() != "GET")
                {
                    var bodyAsString = JsonConvert.SerializeObject(body, this.JsonSerializerSettings);
                    request.Content = new StringContent(bodyAsString, Encoding.UTF8, "application/json");
                    response.RawRequest = bodyAsString;
                }

                this.Client.DefaultRequestHeaders.Authorization = this.GenerateBasicAuth(this.Configuration.SecretKey, "");

                var httpResponse = Task.Run(() => this.Client.SendAsync(request)).Result;

                response = this.HandleResponse<T>(httpResponse);
            }
            catch (Exception ex)
            {
                response.Exception = ex;
            }

            stopwatch.Stop();
            response.ElapsedTime = stopwatch.ElapsedMilliseconds;

            return response;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Creates basic auth
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        private AuthenticationHeaderValue GenerateBasicAuth(string username, string password)
        {
            var credentials = string.Format("{0}:{1}", username, password);
            var token = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(credentials));
            var authorization = new AuthenticationHeaderValue("Basic", token);

            return authorization;
        }

        /// <summary>
        /// Mount full url considering Configuration.ApiUrl and query string
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        /// <param name="query">Query data</param>
        /// <returns></returns>
        private string GetFullUri(string endpoint, IDictionary<string, string> query)
        {
            var fullUri = string.Concat(this.Configuration.ApiUrl.TrimEnd('\\'), endpoint);

            if (query != null && query.Any())
            {
                var builder = new UriBuilder(fullUri);
                var currentQuery = HttpUtility.ParseQueryString(builder.Query);

                var queryWithoutNulls = query.Where(r => string.IsNullOrWhiteSpace(r.Value) == false);
                foreach (var queryItem in queryWithoutNulls)
                {
                    currentQuery[queryItem.Key] = queryItem.Value;
                }

                builder.Query = currentQuery.ToString();
                fullUri = builder.ToString();
            }

            return fullUri;
        }

        /// <summary>
        /// Handle and mount response
        /// </summary>
        /// <typeparam name="T">Response type</typeparam>
        /// <param name="httpResponse">HttpResponseMessage received from native HttpClient</param>
        /// <returns></returns>
        private BaseResponse<T> HandleResponse<T>(HttpResponseMessage httpResponse)
        {
            BaseResponse<T> response = new BaseResponse<T>();
            response.StatusCode = httpResponse.StatusCode;

            var responseBody = httpResponse.Content.ReadAsStringAsync().Result;

            response.RawResponse = responseBody;

            if (httpResponse.IsSuccessStatusCode == true && string.IsNullOrWhiteSpace(responseBody) == false)
            {
                response.Data = JsonConvert.DeserializeObject<T>(responseBody, this.JsonSerializerSettings);
            }
            else if (httpResponse.IsSuccessStatusCode == false && string.IsNullOrWhiteSpace(responseBody) == false)
            {
                response.Errors = JsonConvert.DeserializeObject<ErrorsResponse>(responseBody, this.JsonSerializerSettings);
            }

            return response;
        }

        #endregion Private Methods
    }
}