namespace Mundipagg.Models.Request
{
    public class CreateSplitRequest
    {

        public int Amount { get; set; }

        public CreateSplitOptionsRequest Options { get; set; }

        public string RecipientId { get; set; }

        public string Type { get; set; }

    }
}