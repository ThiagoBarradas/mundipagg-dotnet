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

        public CreateNetworkTokenRequest NetworkToken { get; set; }

        public string EntryMode { get; set; }

        public string AcquirerAffiliationKey { get; set; }

        public string OperationType { get; set; }

        public CreatePOIRequest Poi { get; set; }
    }
}