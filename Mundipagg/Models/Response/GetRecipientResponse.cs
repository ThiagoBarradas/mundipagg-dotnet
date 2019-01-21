using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetRecipientResponse
    {

        public DateTime CreatedAt { get; set; }

        public GetBankAccountResponse DefaultBankAccount { get; set; }

        public DateTime DeletedAt { get; set; }

        public string Description { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public List<GetGatewayRecipientResponse> GatewayRecipients { get; set; }

        public string Id { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}