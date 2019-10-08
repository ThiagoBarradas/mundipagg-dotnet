using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Commons
{
    /// <summary>
    /// Paging response
    /// </summary>
    /// <typeparam name="T">Response type</typeparam>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PagingResponse<T>
    {
        /// <summary>
        /// Items 
        /// </summary>
        public T[] Data { get; set; }

        /// <summary> 
        /// Pagination info
        /// </summary>
        public Paging Paging { get; set; }
    }
}