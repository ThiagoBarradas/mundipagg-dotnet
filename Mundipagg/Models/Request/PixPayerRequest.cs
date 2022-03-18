using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PixPayerRequest
    {
        public string Name { get; set; }

        public string Document { get; set; }

        public string DocumentType { get; set; }

        public PixBankAccountRequest BankAccount { get; set; }
    }
}
