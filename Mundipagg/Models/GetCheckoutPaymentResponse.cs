using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetCheckoutPaymentResponse 
    {
        public string Id { get; set; }
        public int? Amount { get; set; }
        public string DefaultPaymentMethod { get; set; }
        public string SuccessUrl { get; set; }
        public string PaymentUrl { get; set; }
        public string GatewayAffiliationId { get; set; }
        public List<string> AcceptedPaymentMethods { get; set; }
        public string Status { get; set; }
        public bool SkipCheckoutSuccessPage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? CanceledAt { get; set; }
        public bool CustomerEditable { get; set; }
        public GetCustomerResponse Customer { get; set; }
        public GetAddressResponse Billingaddress { get; set; }
        public GetCheckoutCreditCardPaymentResponse CreditCard { get; set; }
        public GetCheckoutBoletoPaymentResponse Boleto { get; set; }
        public bool BillingAddressEditable { get; set; }
        public GetShippingResponse Shipping { get; set; }
        public bool Shippable { get; set; }
        public DateTime? ClosedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public string Currency { get; set; }
        public GetCheckoutDebitCardPaymentResponse DebitCard { get; set; }
    }
} 