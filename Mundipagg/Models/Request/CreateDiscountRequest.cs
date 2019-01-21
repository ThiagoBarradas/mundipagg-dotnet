namespace Mundipagg.Models.Request
{
    public class CreateDiscountRequest
    {
        public int? Cycles { get; set; }

        public string Description { get; set; }

        public string DiscountType { get; set; }

        public string ItemId { get; set; }

        public double Mvalue { get; set; }
    }
}