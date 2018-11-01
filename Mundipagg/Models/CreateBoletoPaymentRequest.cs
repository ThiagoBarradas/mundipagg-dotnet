using System;


namespace Mundipagg.Models
{
    public class CreateBoletoPaymentRequest
    {
        public int Retries { get; set; }
        public string Bank { get; set; }
        public string Instructions { get; set; }
        public DateTime? DueAt { get; set; }
        public CreateAddressRequest BillingAddress { get; set; }
        public string BillingAddressId { get; set; }
        public string NossoNumero { get; set; }
        public string DocumentNumber { get; set; }
    }
} 