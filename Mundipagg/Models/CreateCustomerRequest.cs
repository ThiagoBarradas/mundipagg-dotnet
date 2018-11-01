using System.Collections.Generic;

namespace Mundipagg.Models
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string Type { get; set; }
        public CreateAddressRequest Address { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public CreatePhonesRequest Phones { get; set; }
        public string Code { get; set; }
        public string Gender { get; set; }
    }
} 