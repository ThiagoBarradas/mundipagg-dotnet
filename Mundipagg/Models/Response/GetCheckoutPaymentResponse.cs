using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutPaymentResponse
    {
        public List<string> AcceptedPaymentMethods { get; set; }

        public int? Amount { get; set; }

        public GetAddressResponse Billingaddress { get; set; }

        public bool BillingAddressEditable { get; set; }

        public GetCheckoutBoletoPaymentResponse Boleto { get; set; }

        public DateTime? CanceledAt { get; set; }

        public DateTime? ClosedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetCheckoutCreditCardPaymentResponse CreditCard { get; set; }

        public string Currency { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public bool CustomerEditable { get; set; }

        public GetCheckoutDebitCardPaymentResponse DebitCard { get; set; }

        public string DefaultPaymentMethod { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public string GatewayAffiliationId { get; set; }

        public string Id { get; set; }

        public string PaymentUrl { get; set; }

        public bool Shippable { get; set; }

        public GetShippingResponse Shipping { get; set; }

        public bool SkipCheckoutSuccessPage { get; set; }

        public string Status { get; set; }

        public string SuccessUrl { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}