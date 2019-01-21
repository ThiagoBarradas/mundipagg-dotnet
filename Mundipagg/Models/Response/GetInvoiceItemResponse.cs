namespace Mundipagg.Models.Response
{
    public class GetInvoiceItemResponse
    {
        public int Amount { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public GetPriceBracketResponse PriceBracket { get; set; }

        public GetPricingSchemeResponse PricingScheme { get; set; }

        public int? Quantity { get; set; }

        public string SubscriptionItemId { get; set; }
    }
}