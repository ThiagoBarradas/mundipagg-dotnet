using Mundipagg.Models.Response;
using Newtonsoft.Json;
using PackUtils;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Mundipagg.Utils
{
    /// <summary>
    /// RestSharp client utility
    /// </summary>
    internal class RestSharpClientUtil : IHttpClientUtil
    {
        /// <summary>
        /// Creates a new http client utility
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        public RestSharpClientUtil(Configuration configuration)
        {
            this.Configuration = configuration;
            this.Client = new RestClientAutolog();
            this.Client.Configuration.JsonBlacklist = new string[]
                { "*card.token", "*card.exp_year", "*card.exp_month", "*card.cvv", "*card.number",
                  "token", "exp_year", "exp_month", "cvv", "number"};
            this.Client.AddDefaultHeader("User-Agent", "Mundipagg Dotnet SDK");
            this.Client.AddNewtonsoftResponseHandler(NewtonsoftRestsharpJsonSerializer);
            this.Client.Timeout = configuration.Timeout;
        }

        /// <summary>
        /// JsonSerializer
        /// </summary>
        private static readonly JsonSerializer JsonSerializer = JsonUtility.SnakeCaseJsonSerializer;

        /// <summary>
        /// JsonSerializerSettings
        /// </summary>
        private static readonly JsonSerializerSettings JsonSerializerSettings = JsonUtility.SnakeCaseJsonSerializerSettings;

        /// <summary>
        /// Newtonsoft JsonSerializer for Restsharp
        /// </summary>
        private static NewtonsoftRestsharpJsonSerializer NewtonsoftRestsharpJsonSerializer = new NewtonsoftRestsharpJsonSerializer(JsonSerializer);

        /// <summary>
        /// RestSharp Client HttpClient
        /// </summary>
        private RestClientAutolog Client { get; set; }
        
        /// <summary>
        /// Mundipagg Api Client Configuration
        /// </summary>
        private Configuration Configuration { get; set; }

        /// <summary>
        /// Send request and mount response to client format
        /// </summary>
        /// <typeparam name="T">Response type</typeparam>
        /// <param name="httpMethod">Method to call</param>
        /// <param name="endpoint">Endpoint to call</param>
        /// <param name="body">Body object</param>
        /// <param name="query">Params to mount query string</param>
        /// <returns>Base response with specific data defined in T</returns>
        public BaseResponse<T> SendRequest<T>(HttpMethod httpMethod, string endpoint, object body, IDictionary<string, string> query = null)
            where T : class, new()
        {
            BaseResponse<T> response = new BaseResponse<T>();
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var fullUri = this.GetFullUri(endpoint, query);
            var method = EnumUtility.ConvertToEnum<Method>(httpMethod.Method.ToUpper());

            this.Client.BaseUrl = new Uri(fullUri);

            var restRequest = new RestRequest(method);
            restRequest.AddNewtonsoftRequestHandler(NewtonsoftRestsharpJsonSerializer);
            restRequest.AddHeader("RequestKey", this.Configuration.RequestKey);

            if (body != null && method != Method.GET)
            {
                restRequest.AddJsonBody(body);
                response.RawRequest = JsonConvert.SerializeObject(body, JsonSerializerSettings);
            }

            this.Client.Authenticator = new HttpBasicAuthenticator(this.Configuration.SecretKey, "");

            var restResponse = this.Client.Execute<T>(restRequest);
            this.HandleResponse(response, restResponse);

            stopwatch.Stop();       
            response.ElapsedTime = stopwatch.ElapsedMilliseconds;

            return response;
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
        /// <param name="restResponse">HttpResponseMessage received from RestSharp HttpClient</param>
        /// <returns></returns>
        private void HandleResponse<T>(BaseResponse<T> response, IRestResponse<T> restResponse)
        {
            response.StatusCode = restResponse.StatusCode;

            response.RawResponse = restResponse.Content;

            if (restResponse.ErrorException != null)
            {
                response.Exception = restResponse.ErrorException;
            }

            if (restResponse.IsSuccessful == true && 
                string.IsNullOrWhiteSpace(response.RawResponse) == false &&
                restResponse.Data != null)
            {
                response.Data = restResponse.Data;
            }
            else if (restResponse.IsSuccessful == false && 
                     string.IsNullOrWhiteSpace(response.RawResponse) == false)
            {
                response.Errors = JsonConvert.DeserializeObject<ErrorsResponse>(response.RawResponse, JsonSerializerSettings);
            }
        }
    }
}