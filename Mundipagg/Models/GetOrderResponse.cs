using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetOrderResponse
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Currency { get; set; }
        public List<GetOrderItemResponse> Items { get; set; }
        public GetCustomerResponse Customer { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<GetChargeResponse> Charges { get; set; }
        public string InvoiceUrl { get; set; }
        public GetShippingResponse Shipping { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public List<GetCheckoutPaymentResponse> Checkouts { get; set; }
        public string Ip { get; set; }
        public string SessionId { get; set; }
        public GetLocationResponse Location { get; set; }
        public GetDeviceResponse Device { get; set; }
        public bool Closed { get; set; }
    }
} 