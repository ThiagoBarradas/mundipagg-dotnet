using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetRecipientResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public GetBankAccountResponse DefaultBankAccount { get; set; }

        public GetTransferSettingsResponse TransferSettings { get; set; }

        public List<GetGatewayRecipientResponse> GatewayRecipients { get; set; }

        public GetAutomaticAnticipationSettingsResponse AutomaticAnticipationSettings { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}