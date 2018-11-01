using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class UpdateCardRequest 
    {
        public string HolderName { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string BillingAddressId { get; set; }
        public CreateAddressRequest BillingAddress { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
    }
} 