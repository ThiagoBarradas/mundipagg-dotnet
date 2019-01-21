using System;

namespace Mundipagg.Models.Request
{
    public class CreateBoletoPaymentRequest
    {

        public string Bank { get; set; }

        public CreateAddressRequest BillingAddress { get; set; }

        public string BillingAddressId { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime? DueAt { get; set; }

        public string Instructions { get; set; }

        public string NossoNumero { get; set; }

        public int Retries { get; set; }

    }
}