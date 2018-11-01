using System;


namespace Mundipagg.Models
{
    public class CreateCheckoutBoletoPaymentRequest 
    {
        public string Bank { get; set; }
        public string Instructions { get; set; }
        public DateTime DueAt { get; set; }
    }
} 