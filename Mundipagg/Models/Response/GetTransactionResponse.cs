using Mundipagg.Models.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        public List<GetSplitResponse> Split { get; set; }

        public string Status { get; set; }

        public bool Success { get; set; }

        public string TransactionType { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string BrandReturnCode { get; set; }

        public string AcquirerOid { get; set; }

        public string IssuerTid { get; set; }

        public string IccData { get; set; }

        public DateTime? InitiatorDate { get; set; }

        public string InitiatorReference { get; set; }

        public string InitiatorTransactionKey { get; set; }

        public string DeviceSerialNumber { get; set; }

        public string EntryMode { get; set; }

        public GetActionPOIInformationResponse Action { get; set; }

        public string OperationKey { get; set; }
    }
}