using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using Mundipagg.Models.Commons;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetPixTransactionResponse : GetTransactionResponse
    {
        public string QrCode { get; set; }

        public string QrCodeUrl { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public List<PixAdditionalInformation> AdditionalInformation { get; set; }
    }
}