using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateCheckoutBankTransferRequest
    {
        public List<string> Bank { get; set; }

        public int Retries { get; set; }
    }
}