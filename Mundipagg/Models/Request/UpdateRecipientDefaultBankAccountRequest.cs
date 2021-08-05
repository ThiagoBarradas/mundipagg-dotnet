using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateRecipientDefaultBankAccountRequest
    {
        public UpdateBankAccountRequest BankAccount { get; set; }
    }
}
