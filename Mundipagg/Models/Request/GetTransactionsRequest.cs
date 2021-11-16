using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetTransactionsRequest
    {
        public string InitiatorTransactionKey { get; set; }
        public string ChargeId { get; set; }
    }
}
