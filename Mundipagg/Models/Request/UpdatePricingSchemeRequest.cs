using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdatePricingSchemeRequest
    {
        public int? MinimumPrice { get; set; }

        public int? Price { get; set; }

        public List<UpdatePriceBracketRequest> PriceBrackets { get; set; }

        public string SchemeType { get; set; }
    }
}