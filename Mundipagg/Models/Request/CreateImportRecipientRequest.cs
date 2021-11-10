﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateImportRecipientRequest
    {
        public string GatewayId { get; set; }
        public bool? DefaultRecipient { get; set; }
    }
}
