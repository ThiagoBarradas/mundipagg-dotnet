namespace Mundipagg.Models
{
    public class ListIncrementsRequest : BaseListRequest
    {
        public ListIncrementsRequest(string subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        public string SubscriptionId { get; set; }
    }
}
