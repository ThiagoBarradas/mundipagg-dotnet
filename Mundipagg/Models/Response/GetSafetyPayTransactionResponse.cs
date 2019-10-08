using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetSafetyPayTransactionResponse : GetTransactionResponse
    {
        public string BankTid { get; set; }

        public int? PaidAmount { get; set; }

        public DateTime? PaidAt { get; set; }

        public string Url { get; set; }
    }
}