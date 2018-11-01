using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateChargeRequest 
    {
        public string Code { get; set; }
        public int Amount { get; set; }
        public string CustomerId { get; set; }
        public CreateCustomerRequest Customer { get; set; }
        public CreatePaymentRequest Payment { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public DateTime? DueAt { get; set; }
    }
} 