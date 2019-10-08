using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BaseResponse<T>
    {
        /// <summary>
        /// Success data - Is set when status code is 2XX
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Elapsed time to call Mundipagg Api
        /// </summary>
        public long ElapsedTime { get; set; }

        /// <summary>
        /// Error data - Is set when status code is 4XX or 5XX
        /// </summary>
        public ErrorsResponse Errors { get; set; }

        /// <summary>
        /// Exception - Is set when an exception occurs
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// Raw request in json
        /// </summary>
        public string RawRequest { get; set; }

        /// <summary>
        /// Raw response in json
        /// </summary>
        public string RawResponse { get; set; }

        /// <summary>
        /// Http status code
        /// </summary>
        public HttpStatusCode? StatusCode { get; set; }
    }
}