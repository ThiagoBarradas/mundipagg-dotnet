using System;

namespace Mundipagg.Models.Request
{
    public class CreateCheckoutBoletoPaymentRequest
    {
        public string Bank { get; set; }

        public DateTime DueAt { get; set; }

        public string Instructions { get; set; }
    }
}