using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCreditCardPaymentRequest
    {
        public CreatePaymentAuthenticationRequest Authentication { get; set; }

        public bool? Capture { get; set; } = true;

        public CreateCardRequest Card { get; set; }

        public CreateNetworkTokenRequest NetworkToken { get; set; }

        public string CardId { get; set; }

        public string CardToken { get; set; }

        public string ExtendedLimitCode { get; set; }

        public bool? ExtendedLimitEnabled { get; set; }

        public int? Installments { get; set; } = 1;

        public long? MerchantCategoryCode { get; set; }

        public bool? Recurrence { get; set; }

        public string StatementDescriptor { get; set; }

        public CreateCardPaymentTokenRequest Token { get; set; }

        public string InstallmentType { get; set; }

        public string EntryMode { get; set; }

        public string AcquirerAffiliationKey { get; set; }

        public string OperationType { get; set; }

        public CreatePOIRequest Poi { get; set; }
    }
}