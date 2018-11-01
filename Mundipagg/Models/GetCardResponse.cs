using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetCardResponse
    {
        public string Id { get; set; }
        public string LastFourDigits { get; set; }
        public string Brand { get; set; }
        public string HolderName { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public GetBillingAddressResponse BillingAddress { get; set; }
        public GetCustomerResponse Customer { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public string Type { get; set; }
        public string HolderDocument { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string FirstSixDigits { get; set; }
    }
} 