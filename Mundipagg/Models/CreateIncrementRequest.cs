namespace Mundipagg.Models
{
    public class CreateIncrementRequest  
    {
        public double Mvalue { get; set; }
        public string IncrementType { get; set; }
        public string ItemId { get; set; }
        public int? Cycles { get; set; }
        public string Description { get; set; }
    }
} 