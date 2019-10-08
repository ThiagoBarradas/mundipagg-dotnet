using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateVoucherPaymentRequest
    {
        public CreateCardRequest Card { get; set; }

        public bool? Capture { get; set; }
        
        public string CardId { get; set; }

        public string CardToken { get; set; }

        public string StatementDescriptor { get; set; }
    }
}
