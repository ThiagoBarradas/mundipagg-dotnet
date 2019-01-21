namespace Mundipagg.Models.Request
{
    public class UpdateOrderItemRequest
    {

        public int Amount { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

    }
}