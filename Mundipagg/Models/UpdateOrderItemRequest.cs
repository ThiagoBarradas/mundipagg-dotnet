namespace Mundipagg.Models
{
    public class UpdateOrderItemRequest 
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }
} 