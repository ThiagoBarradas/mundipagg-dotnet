namespace Mundipagg.Models
{
    public class GetOrderItemResponse 
    {
        public string Id { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public GetSellerResponse GetSellerResponse { get; set; }
        public string Category { get; set; }
    }
} 