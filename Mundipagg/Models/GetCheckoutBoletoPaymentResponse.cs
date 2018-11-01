using System;


namespace Mundipagg.Models
{
    public class GetCheckoutBoletoPaymentResponse 
    {
        public DateTime DueAt { get; set; }
        public string Instructions { get; set; }
    }
} 