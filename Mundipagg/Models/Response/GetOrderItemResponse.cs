namespace Mundipagg.Models.Response
{
    public class GetOrderItemResponse
    {
        #region Public Properties

        public int Amount { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public GetSellerResponse GetSellerResponse { get; set; }

        public string Id { get; set; }

        public int Quantity { get; set; }

        #endregion Public Properties
    }
}