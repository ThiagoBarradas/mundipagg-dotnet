namespace Mundipagg.Models.Request
{
    public class UpdateOrderItemRequest
    {
        #region Public Properties

        public int Amount { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        #endregion Public Properties
    }
}