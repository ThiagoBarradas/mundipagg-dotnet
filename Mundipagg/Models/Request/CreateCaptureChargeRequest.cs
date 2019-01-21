namespace Mundipagg.Models.Request
{
    public class CreateCaptureChargeRequest
    {
        public int? Amount { get; set; }

        public string Code { get; set; }
    }
}