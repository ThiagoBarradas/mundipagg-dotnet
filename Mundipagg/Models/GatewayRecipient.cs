using Mundipagg.Models.Enums;
using Newtonsoft.Json;
using System;

namespace Mundipagg.Models
{
    /// <summary>
    /// Gateway recipient model
    /// </summary>
    public class GatewayRecipient
    {
        /// <summary>
        /// Gateway
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// Gateway recipient status
        /// </summary>
        public GatewayRecipientStatusEnum Status { get; set; }

        /// <summary>
        /// Gateway Id
        /// </summary>
        [JsonProperty("pgid")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
