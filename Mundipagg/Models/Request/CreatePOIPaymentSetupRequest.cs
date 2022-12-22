namespace Mundipagg.Models.Request
{
    public class CreatePOIPaymentSetupRequest
    {
        public string Type { get; set; }

        public int? Installments { get; set; }

        public string InstallmentType { get; set; }

        public int? Amount { get; set; }
    }
}
