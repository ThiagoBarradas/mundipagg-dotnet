using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateCustomerRequest
    {
        public CreateAddressRequest Address { get; set; }

        public string Code { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public CreatePhonesRequest Phones { get; set; }

        public string Type { get; set; }
    }
}