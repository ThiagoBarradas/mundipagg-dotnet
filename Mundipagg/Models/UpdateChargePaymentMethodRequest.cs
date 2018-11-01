namespace Mundipagg.Models
{
    public class UpdateChargePaymentMethodRequest 
    {
        public bool UpdateSubscription { get; set; }
        public string PaymentMethod { get; set; }
        public CreateCreditCardPaymentRequest CreditCard { get; set; }
        public CreateDebitCardPaymentRequest DebitCard { get; set; }
        public CreateBoletoPaymentRequest Boleto { get; set; }
        public CreateVoucherPaymentRequest Voucher { get; set; }
    }
} 