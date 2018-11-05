using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Models
{
    public class ListUsagesRequest: BaseListRequest
    {
        /// <summary>
        /// Filter by subscription id
        /// </summary>
        public string SubscriptionId { get; set; }
        
        /// <summary>
        /// Filter by item id
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Filter by code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Filter by mgroup
        /// </summary>
        public string Mgroup { get; set; }
    }
}
