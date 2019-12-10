using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetPricingSchemeResponse
    {
        public int? MinimumPrice { get; set; }

        public int Price { get; set; }

        public List<GetPriceBracketResponse> PriceBrackets { get; set; }

        public string SchemeType { get; set; }
    }
}