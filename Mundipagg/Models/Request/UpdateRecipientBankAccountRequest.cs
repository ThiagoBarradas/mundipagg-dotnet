using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateRecipientBankAccountRequest
    {
        public CreateBankAccountRequest BankAccount { get; set; }
    }
}