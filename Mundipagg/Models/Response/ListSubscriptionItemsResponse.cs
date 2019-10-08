using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListSubscriptionItemsResponse
    {
        public List<GetSubscriptionItemResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}