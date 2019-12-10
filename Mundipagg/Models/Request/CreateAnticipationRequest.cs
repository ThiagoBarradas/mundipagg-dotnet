using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateAnticipationRequest
    {
        public int Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public string Timeframe { get; set; }
    }
}