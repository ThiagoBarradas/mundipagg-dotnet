namespace Mundipagg.Models.Request
{
    public class UpdateSubscriptionItemRequest
    {
        #region Public Properties

        public int? Cycles { get; set; }

        public string Description { get; set; }

        public int? MinimumPrice { get; set; }

        public string Name { get; set; }

        public UpdatePricingSchemeRequest PricingScheme { get; set; }

        public int? Quantity { get; set; }

        public string Status { get; set; }

        #endregion Public Properties
    }
}