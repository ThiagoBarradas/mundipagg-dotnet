using MundiPagg.Models.Response;
using System.Collections.Generic;
using System.Net.Http;

namespace MundiPagg.Utils
{
    /// <summary>
    /// Http client utility
    /// </summary>
    public interface IHttpClientUtil
    {
        /// <summary>
        /// Send request and mount response to client format
        /// </summary>
        /// <typeparam name="T">Response type</typeparam>
        /// <param name="method">Method to call</param>
        /// <param name="endpoint">Endpoint to call</param>
        /// <param name="body">Body object</param>
        /// <param name="query">Params to mount query string</param>
        /// <returns>Base response with specific data defined in T</returns>
        BaseResponse<T> SendRequest<T>(HttpMethod method, string endpoint, object body, IDictionary<string, string> query = null);
    }
}
