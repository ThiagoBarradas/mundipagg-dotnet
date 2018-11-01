namespace Mundipagg.Models
{
    public class CreateDiscountRequest 
    {
        public double Mvalue { get; set; }
        public string DiscountType { get; set; }
        public string ItemId { get; set; }
        public int? Cycles { get; set; }
        public string Description { get; set; }
    }
} 