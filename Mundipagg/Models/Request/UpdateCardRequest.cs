using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class UpdateCardRequest
    {
        public CreateAddressRequest BillingAddress { get; set; }

        public string BillingAddressId { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string HolderName { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}