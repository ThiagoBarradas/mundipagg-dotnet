using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class UpdateMetadataRequest
    {
        public Dictionary<string, string> Metadata { get; set; }
    }
}