using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCancelChargeRequest
    {
        public int? Amount { get; set; }

        public List<CreateSplitRequest> SplitRules { get; set; }

        public CreatePOIInformationRequest Poi { get; set; }

        public CreateBankAccountRefundingRequest BankAccount { get; set; }
    }
}