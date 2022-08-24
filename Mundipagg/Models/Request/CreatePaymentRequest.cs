using Mundipagg.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PagarMe.Models.Request;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreatePaymentRequest
    {
        public int? Amount { get; set; }

        public string Code { get; set; }

        public PaymentProviderEnum? Provider { get; set; }

        public CreateBankTransferPaymentRequest BankTransfer { get; set; }

        public CreateBoletoPaymentRequest Boleto { get; set; }

        public CreateCashPaymentRequest Cash { get; set; }

        public CreateCheckoutPaymentRequest Checkout { get; set; }

        public CreateCreditCardPaymentRequest CreditCard { get; set; }

        public CreatePrivateLabelPaymentRequest PrivateLabel { get; set; }

        public CreateCustomerRequest Customer { get; set; }

        public string CustomerId { get; set; }

        public CreateDebitCardPaymentRequest DebitCard { get; set; }

        public string GatewayAffiliationId { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string PaymentMethod { get; set; }

        public List<CreateSplitRequest> Split { get; set; }

        public CreateVoucherPaymentRequest Voucher { get; set; }

        public string OperationSource { get; set; }

        public CreatePixPaymentRequest Pix { get; set; }
    }
}