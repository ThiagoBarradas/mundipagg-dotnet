using Newtonsoft.Json;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class UpdateRecipientRequest 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
    }
} 