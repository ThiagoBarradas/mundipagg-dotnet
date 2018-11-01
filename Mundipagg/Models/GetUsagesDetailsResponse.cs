namespace Mundipagg.Models
{
    public class GetUsagesDetailsResponse 
    {
        public string SubscriptionId { get; set; }
        public int TotalAmount { get; set; }
        public GetPeriodResponse Period { get; set; }
        public ListUsagesDetailsResponse Usages { get; set; }
        public int? TotalDiscount { get; set; }
        public int? TotalIncrement { get; set; }
    }
} 