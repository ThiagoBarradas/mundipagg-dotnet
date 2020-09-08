using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutVoucherPaymentRequest
    {
        public bool? Capture { get; set; }
        
        public string StatementDescriptor { get; set; }
    }
}