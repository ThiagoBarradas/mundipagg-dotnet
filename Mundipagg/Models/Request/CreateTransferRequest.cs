using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateTransferRequest
    {

        public int Amount { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

    }
}