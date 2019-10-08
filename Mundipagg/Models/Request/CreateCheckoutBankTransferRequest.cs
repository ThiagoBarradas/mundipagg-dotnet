using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutBankTransferRequest
    {
        public List<string> Bank { get; set; }

        public int Retries { get; set; }
    }
}