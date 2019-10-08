using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetAnticipationResponse
    {
        public int ApprovedAmount { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Id { get; set; }

        public DateTime PaymentDate { get; set; }

        public string Pgid { get; set; }

        public GetRecipientResponse Recipient { get; set; }

        public int RequestedAmount { get; set; }

        public string Status { get; set; }

        public string Timeframe { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}