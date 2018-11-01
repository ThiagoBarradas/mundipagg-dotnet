using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateCardRequest
    {
        public string HolderName { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Cvv { get; set; }
        public CreateAddressRequest BillingAddress { get; set; }
        public string Brand { get; set; }
        public string BillingAddressId { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public string Type { get; set; } = "credit";
        public CreateCardOptionsRequest Options { get; set; }
        public string HolderDocument { get; set; }
        public bool PrivateLabel { get; set; }
        public string Number { get; set; }
    }
} 