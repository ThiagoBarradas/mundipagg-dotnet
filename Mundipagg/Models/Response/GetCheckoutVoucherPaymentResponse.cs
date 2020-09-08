using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutVoucherPaymentResponse
    {
        public bool ?Capture { get; set; }
        
        public string StatementDescriptor { get; set; }
    }
}