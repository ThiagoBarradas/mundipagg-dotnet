using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateCheckoutBankTransferRequest 
    {
        public List<string> Bank { get; set; }
        public int Retries { get; set; }
    }
} 