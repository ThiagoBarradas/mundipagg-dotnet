using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetAddressResponse
    {

        public string City { get; set; }

        public string Complement { get; set; }

        public string Country { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string Id { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Neighborhood { get; set; }

        public string Number { get; set; }

        public string State { get; set; }

        public string Status { get; set; }

        public string Street { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string ZipCode { get; set; }

    }
}