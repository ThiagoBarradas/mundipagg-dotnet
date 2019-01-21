using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class UpdateRecipientRequest
    {

        public string Description { get; set; }

        public string Email { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

    }
}