using Mundipagg.Models.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonConverter(typeof(GetTransactionResponseCreationConverter))]
    public class GetTransactionResponse
    {
        public int Amount { get; set; }

        public int AttemptCount { get; set; }

        public DateTime CreatedAt { get; set; }

        public string GatewayId { get; set; }

        public GetGatewayResponseResponse GatewayResponse { get; set; }

        public GetAntifraudResponse AntifraudResponse { get; set; }

        public string Id { get; set; }

        public int MaxAttempts { get; set; }

        public DateTime? NextAttempt { get; set; }

        public List<GetSplitResponse> Splits { get; set; }

        public string Status { get; set; }

        public bool Success { get; set; }

        public string TransactionType { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}