namespace Mundipagg.Models
{
    public class UpdateSubscriptionCardRequest 
    {
        public CreateCardRequest Card { get; set; }
        public string CardId { get; set; }
    }
} 