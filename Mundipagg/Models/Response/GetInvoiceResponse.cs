using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetInvoiceResponse
    {
        #region Public Properties

        public int Amount { get; set; }

        public GetBillingAddressResponse BillingAddress { get; set; }

        public DateTime? BillingAt { get; set; }

        public DateTime? CanceledAt { get; set; }

        public GetChargeResponse Charge { get; set; }

        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public GetPeriodResponse Cycle { get; set; }

        public DateTime? DueAt { get; set; }

        public string Id { get; set; }

        public int Installments { get; set; }

        public List<GetInvoiceItemResponse> Items { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string PaymentMethod { get; set; }

        public DateTime? SeenAt { get; set; }

        public GetShippingResponse Shipping { get; set; }

        public string Status { get; set; }

        public GetSubscriptionResponse Subscription { get; set; }

        public int? TotalDiscount { get; set; }

        public int? TotalIncrement { get; set; }

        public string Url { get; set; }

        #endregion Public Properties
    }
}