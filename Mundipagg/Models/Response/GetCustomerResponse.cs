using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetCustomerResponse
    {
        public GetAddressResponse Address { get; set; }

        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Delinquent { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public string FbAccessToken { get; set; }

        public long? FbId { get; set; }

        public string Id { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public GetPhonesResponse Phones { get; set; }

        public string Type { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}