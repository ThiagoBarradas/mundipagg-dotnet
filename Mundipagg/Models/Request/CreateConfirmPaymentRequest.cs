namespace Mundipagg.Models.Request
{
    public class CreateConfirmPaymentRequest
    {

        public int? Amount { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

    }
}