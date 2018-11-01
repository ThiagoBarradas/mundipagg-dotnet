using System;


namespace Mundipagg.Models
{
    public class GetShippingResponse
    {
        public int Amount { get; set; }
        public string Description { get; set; }
        public string RecipientName { get; set; }
        public string RecipientPhone { get; set; }
        public GetAddressResponse Address { get; set; }
        public DateTime? MaxDeliveryDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
    }
} 