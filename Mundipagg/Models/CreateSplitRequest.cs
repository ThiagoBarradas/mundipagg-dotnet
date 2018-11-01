namespace Mundipagg.Models
{
    public class CreateSplitRequest 
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public string RecipientId { get; set; }
        public CreateSplitOptionsRequest Options { get; set; }
    }
} 