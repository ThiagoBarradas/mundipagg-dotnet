namespace Mundipagg.Models.Request
{
    public class ListUsagesRequest : BaseListRequest
    {
        #region Public Properties

        /// <summary>
        /// Filter by code
        /// </summary>
        public string Code { get; set; }

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

        #endregion Public Properties
    }
}
