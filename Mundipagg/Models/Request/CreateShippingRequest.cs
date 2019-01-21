using System;

namespace Mundipagg.Models.Request
{
    public class CreateShippingRequest
    {

        public CreateAddressRequest Address { get; set; }

        public string AddressId { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        public DateTime? MaxDeliveryDate { get; set; }

        public string RecipientName { get; set; }

        public string RecipientPhone { get; set; }

    }
}