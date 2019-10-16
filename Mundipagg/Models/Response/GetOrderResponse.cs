using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetOrderResponse
    {
        public int Amount { get; set; }

        public List<GetChargeResponse> Charges { get; set; }

        public List<GetCheckoutPaymentResponse> Checkouts { get; set; }

        public bool Closed { get; set; }

        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Currency { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public GetDeviceResponse Device { get; set; }

        public string Id { get; set; }

        public string InvoiceUrl { get; set; }

        public string Ip { get; set; }

        public List<GetOrderItemResponse> Items { get; set; }

        public GetLocationResponse Location { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string SessionId { get; set; }

        public GetShippingResponse Shipping { get; set; }

        public string Status { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
