using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PixBankAccountRequest
    {
        public string BankName { get; set; }

        public string Ispb { get; set; }

        public string BranchCode { get; set; }

        public string AccountNumber { get; set; }
    }
}
