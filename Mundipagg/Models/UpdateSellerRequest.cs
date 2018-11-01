using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class UpdateSellerRequest 
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public CreateAddressRequest Address { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
    }
} 