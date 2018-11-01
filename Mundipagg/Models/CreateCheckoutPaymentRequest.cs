using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateCheckoutPaymentRequest
    {
        public List<string> AcceptedPaymentMethods { get; set; }
        public object AcceptedMultiPaymentMethods { get; set; }
        public string SuccessUrl { get; set; }
        public string DefaultPaymentMethod { get; set; }
        public string GatewayAffiliationId { get; set; }
        public CreateCheckoutCreditCardPaymentRequest CreditCard { get; set; }
        public CreateCheckoutDebitCardPaymentRequest DebitCard { get; set; }
        public CreateCheckoutBoletoPaymentRequest Boleto { get; set; }
        public bool? CustomerEditable { get; set; }
        public int? ExpiresIn { get; set; }
        public bool SkipCheckoutSuccessPage { get; set; }
        public bool BillingAddressEditable { get; set; }
        public CreateAddressRequest BillingAddress { get; set; }
        public CreateCheckoutBankTransferRequest BankTransfer { get; set; }
    }
} 