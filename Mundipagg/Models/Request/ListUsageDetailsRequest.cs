namespace Mundipagg.Models.Request
{
    public class ListUsageDetailsRequest : BaseListRequest
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="subscriptionId">required</param>
        /// <param name="itemId"></param>
        /// <param name="cycleId"></param>
        /// <param name="mgroup"></param>
        public ListUsageDetailsRequest(string subscriptionId, string itemId = null, string cycleId = null, string mgroup = null)
        {
            SubscriptionId = subscriptionId;
            ItemId = itemId;
            CycleId = cycleId;
            Mgroup = mgroup;
        }

        /// <summary>
        /// Filter by code
        /// </summary>
        public string CycleId { get; set; }

        /// <summary>
        /// Filter by item id
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Filter by mgroup
        /// </summary>
        public string Mgroup { get; set; }

        /// <summary>
        /// Filter by subscription id
        /// </summary>
        public string SubscriptionId { get; set; }
    }
}