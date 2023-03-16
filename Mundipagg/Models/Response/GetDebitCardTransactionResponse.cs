using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetDebitCardTransactionResponse : GetTransactionResponse
    {
        public string AcquirerAffiliationCode { get; set; }

        public string AcquirerAuthCode { get; set; }

        public string AcquirerMessage { get; set; }

        public string AcquirerName { get; set; }

        public string AcquirerNsu { get; set; }

        public string AcquirerReturnCode { get; set; }

        public string AcquirerTid { get; set; }

        public string AuthenticationType { get; set; }

        public string FundingSource { get; set; }

        public GetCardResponse Card { get; set; }

        public string Eci { get; set; }

        public string Mpi { get; set; }

        public string OperationType { get; set; }

        public string StatementDescriptor { get; set; }

        public string ThreedAuthenticationUrl { get; set; }
    }
}