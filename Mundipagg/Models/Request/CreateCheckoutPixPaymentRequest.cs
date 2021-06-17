using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using Mundipagg.Models.Commons;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutPixPaymentRequest
    {
        public DateTime? ExpiresAt { get; set; }

        public int? ExpiresIn { get; set; }

        public List<PixAdditionalInformation> AdditionalInformation { get; set; }
    }
}