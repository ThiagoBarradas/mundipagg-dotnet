using System;

namespace Mundipagg.Models.Response
{
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