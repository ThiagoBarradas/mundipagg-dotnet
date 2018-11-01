namespace Mundipagg.Models
{
    public class UpdatePriceBracketRequest 
    {
        public int StartQuantity { get; set; }
        public int Price { get; set; }
        public int? EndQuantity { get; set; }
        public int? OveragePrice { get; set; }
    }
} 