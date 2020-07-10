using Mundipagg.Models.Enums;
using System;

namespace Mundipagg.Models.Request
{

    public class ListOrdersRequest : BaseListRequest
    {
        public string Code { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string CustomerId { get; set; }

        public PaymentMethodTypeEnum PaymentMethod { get; set; }

        public OrderStatusEnum Status { get; set; }
    }
}