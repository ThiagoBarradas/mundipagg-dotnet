namespace Mundipagg.Models.Request
{
    public class CreateSetupRequest
    {

        public int Amount { get; set; }

        public string Description { get; set; }

        public CreatePaymentRequest Payment { get; set; }

    }
}