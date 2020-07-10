using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateCheckoutSettingsRequest
    {
        public string SuccessUrl { get; set; }

        public string[] AcceptedPaymentMethods { get; set; }

        public string DefaultPaymentMethod { get; set; }

        public string[] AcceptedBrands { get; set; }

        public string AddressType { get; set; }

        public bool Enabled { get; set; }

        public string[] RequiredFields { get; set; }

        public string[] OptionalFields { get; set; }
    }
}
