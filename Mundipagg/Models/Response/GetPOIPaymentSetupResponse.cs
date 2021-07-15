namespace Mundipagg.Models.Response
{
    public class GetPOIPaymentSetupResponse
    {
        public string Type { get; set; }

        public int? Installments { get; set; }

        public string InstallmentType { get; set; }
    }
}
