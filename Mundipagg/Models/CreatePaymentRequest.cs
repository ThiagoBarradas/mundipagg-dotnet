using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreatePaymentRequest
    {
        public string PaymentMethod { get; set; }
        public CreateCreditCardPaymentRequest CreditCard { get; set; }
        public CreateDebitCardPaymentRequest DebitCard { get; set; }
        public CreateBoletoPaymentRequest Boleto { get; set; }
        public string Currency { get; set; }
        public CreateVoucherPaymentRequest Voucher { get; set; }
        public List<CreateSplitRequest> Split { get; set; }
        public CreateBankTransferPaymentRequest BankTransfer { get; set; }
        public string GatewayAffiliationId { get; set; }
        public int? Amount { get; set; }
        public CreateCheckoutPaymentRequest Checkout { get; set; }
        public string CustomerId { get; set; }
        public CreateCustomerRequest Customer { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public CreateCashPaymentRequest Cash { get; set; }
    }
} 