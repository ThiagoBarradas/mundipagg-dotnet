namespace Mundipagg.Models
{
    public class CreateOrderItemRequest
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public CreateSellerRequest Seller { get; set; }
        public string SellerId { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
    }
} 