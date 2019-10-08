using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateDebitCardPaymentRequest
    {
        public CreatePaymentAuthenticationRequest Authentication { get; set; }

        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public string CardToken { get; set; }

        public bool? Recurrence { get; set; }

        public string StatementDescriptor { get; set; }

        public CreateCardPaymentTokenRequest Token { get; set; }
    }
}