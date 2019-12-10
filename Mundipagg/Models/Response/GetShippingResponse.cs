using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetShippingResponse
    {
        public GetAddressResponse Address { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        public DateTime? MaxDeliveryDate { get; set; }

        public string RecipientName { get; set; }

        public string RecipientPhone { get; set; }
    }
}