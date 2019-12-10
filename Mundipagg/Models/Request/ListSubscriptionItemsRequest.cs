using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListSubscriptionItemsRequest : BaseListRequest
    {
        public ListSubscriptionItemsRequest(string subscriptionId, string name = null, string description = null, string itemId = null, string code = null,
            DateTime? createdSince = null, DateTime? createdUntil = null)
        {
            SubscriptionId = subscriptionId;
            Name = name;
            Description = description;
            ItemId = itemId;
            Code = code;
            CreatedSince = createdSince;
            CreatedUntil = createdUntil;
        }

        /// <summary>
        /// Filter by code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Filter by create date - Creation after this date
        /// </summary>
        public DateTime? CreatedSince { get; set; }

        /// <summary>
        /// Filter by create date - Creation before this date
        /// </summary>
        public DateTime? CreatedUntil { get; set; }

        /// <summary>
        /// Filter by description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Filter by item id
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Filter by name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Filter by subscription id
        /// </summary>
        public string SubscriptionId { get; set; }
    }
}