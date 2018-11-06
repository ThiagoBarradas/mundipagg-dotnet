using System;

namespace Mundipagg.Models.Response
{
    public class GetUsageResponse
    {
        #region Public Properties

        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public string Mgroup { get; set; }

        public int Quantity { get; set; }

        public string Status { get; set; }

        public GetSubscriptionItemResponse SubscriptionItem { get; set; }

        public DateTime UsedAt { get; set; }

        #endregion Public Properties
    }
}