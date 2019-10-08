using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCardResponse
    {
        public GetBillingAddressResponse BillingAddress { get; set; }

        public string Brand { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string FirstSixDigits { get; set; }

        public string HolderDocument { get; set; }

        public string HolderName { get; set; }

        public string Id { get; set; }

        public string LastFourDigits { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}