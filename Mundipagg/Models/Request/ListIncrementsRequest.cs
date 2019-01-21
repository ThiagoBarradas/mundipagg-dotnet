namespace Mundipagg.Models.Request
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