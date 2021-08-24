using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreatePOIInformationRequest
    {
        public DateTime? InitiatorDate { get; set; }
        public string InitiatorReference { get; set; }
    }
}
