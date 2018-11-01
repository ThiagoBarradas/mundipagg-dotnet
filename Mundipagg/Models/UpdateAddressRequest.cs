using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class UpdateAddressRequest 
    {
        public string Number { get; set; }
        public string Complement { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public string Line2 { get; set; }
    }
} 