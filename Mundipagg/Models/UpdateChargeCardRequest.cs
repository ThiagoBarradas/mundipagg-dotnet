namespace Mundipagg.Models
{
    public class UpdateChargeCardRequest 
    {
        public bool UpdateSubscription { get; set; }
        public string CardId { get; set; }
        public CreateCardRequest Card { get; set; }
        public bool Recurrence { get; set; }
    }
} 