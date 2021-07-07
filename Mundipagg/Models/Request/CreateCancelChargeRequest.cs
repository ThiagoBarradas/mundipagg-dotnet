using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCancelChargeRequest
    {
        public int? Amount { get; set; }

        public List<CreateCancelChargeSplitRequest> Split { get; set; }
    }
}