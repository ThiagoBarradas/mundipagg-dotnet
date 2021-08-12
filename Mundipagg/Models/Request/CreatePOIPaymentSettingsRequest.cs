namespace Mundipagg.Models.Request
{
    public class CreatePOIPaymentSettingsRequest
    {
        public bool? Visible { get; set; }

        public string FilterCode { get; set; }

        public string DisplayName { get; set; }

        public bool? PrintOrderReciept { get; set; }

        public bool? PrintCustomerReciept { get; set; }

        public bool? PrintSellerReciept { get; set; }

        public bool? AllowOverPayment { get; set; }

        public string Source { get; set; }

        public CreatePOIPaymentSetupRequest PaymentSetup { get; set; }

        public string[] DevicesSerialNumber { get; set; }
    }
}
