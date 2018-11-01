using System.Collections.Generic;

namespace Mundipagg.Models
{
    public class CreateOrderRequest
    {
        public List<CreateOrderItemRequest> Items { get; set; }
        public CreateCustomerRequest Customer { get; set; }
        public List<CreatePaymentRequest> Payments { get; set; }
        public string Code { get; set; }
        public string CustomerId { get; set; }
        public CreateShippingRequest Shipping { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public bool? AntifraudEnabled { get; set; }
        public string Ip { get; set; }
        public string SessionId { get; set; }
        public CreateLocationRequest Location { get; set; }
        public CreateDeviceRequest Device { get; set; }
        public bool Closed { get; set; } = true;
        public string Currency { get; set; }
    }
} 