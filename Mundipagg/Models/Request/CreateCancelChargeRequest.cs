using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCancelChargeRequest
    {
        public int? Amount { get; set; }

        public List<CreateSplitRequest> SplitRules { get; set; }

        public DateTime? InitiatorDate { get; set; }

        public string InitiatorReference { get; set; }
    }
}