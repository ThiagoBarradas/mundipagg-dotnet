﻿using Mundipagg.Models.Enums;
using System;

namespace Mundipagg.Models.Request
{
    public class ListChargesRequest : BaseListRequest
    {
        public string Code { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string CustomerId { get; set; }

        public string OrderId { get; set; }

        public PaymentMethodTypeEnum? PaymentMethod { get; set; } = PaymentMethodTypeEnum.CreditCard;

        public ChargeStatusEnum? Status { get; set; } = ChargeStatusEnum.Pending;

        public string InitiatorTransactionKey { get; set; }
    }
}