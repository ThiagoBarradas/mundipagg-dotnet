using System.Runtime.Serialization;

namespace MundiPagg.Models.Enums
{
    /// <summary>
    /// Webhook events enum
    /// </summary>
    public enum WebhookEventEnum
    {
        Undefined,

        // Customer
        [EnumMember(Value = "customer.created")]
        CustomerCreated,
        [EnumMember(Value = "customer.updated")]
        CustomerUpdated,

        // Card
        [EnumMember(Value = "card.created")]
        CardCreated,
        [EnumMember(Value = "card.updated")]
        CardUpdated,
        [EnumMember(Value = "card.deleted")]
        CardDeleted,

        // Address
        [EnumMember(Value = "address.created")]
        AddressCreated,
        [EnumMember(Value = "address.updated")]
        AddressUpdated,
        [EnumMember(Value = "address.deleted")]
        AddressDeleted,

        // Plan
        [EnumMember(Value = "plan.created")]
        PlanCreated,
        [EnumMember(Value = "plan.updated")]
        PlanUpdated,
        [EnumMember(Value = "plan.deleted")]
        PlanDeleted,

        // PlanItem
        [EnumMember(Value = "plan_item.created")]
        PlanItemCreated,
        [EnumMember(Value = "plan_item.updated")]
        PlanItemUpdated,
        [EnumMember(Value = "plan_item.deleted")]
        PlanItemDeleted,

        // Subscription
        [EnumMember(Value = "subscription.created")]
        SubscriptionCreated,
        [EnumMember(Value = "subscription.canceled")]
        SubscriptionCanceled,
        [EnumMember(Value = "subscription.updated")]
        SubscriptionUpdated,
        [EnumMember(Value = "subscription.deleted")]
        SubscriptionDeleted,

        // SubscriptionItem
        [EnumMember(Value = "subscription_item.created")]
        SubscriptionItemCreated,
        [EnumMember(Value = "subscription_item.updated")]
        SubscriptionItemUpdated,
        [EnumMember(Value = "subscription_item.deleted")]
        SubscriptionItemDeleted,

        // Discount
        [EnumMember(Value = "discount.created")]
        DiscountCreated,
        [EnumMember(Value = "discount.deleted")]
        DiscountDeleted,

        // Order
        [EnumMember(Value = "order.paid")]
        OrderPaid,
        [EnumMember(Value = "order.payment_failed")]
        OrderPaymentFailed,
        [EnumMember(Value = "order.created")]
        OrderCreated,
        [EnumMember(Value = "order.canceled")]
        OrderCanceled,
        [EnumMember(Value = "order.closed")]
        OrderClosed,
        [EnumMember(Value = "order.updated")]
        OrderUpdated,

        // OrderItem
        [EnumMember(Value = "order_item.created")]
        OrderItemCreated,
        [EnumMember(Value = "order_item.updated")]
        OrderItemUpdated,
        [EnumMember(Value = "order_item.deleted")]
        OrderItemDeleted,
        
        // Invoice
        [EnumMember(Value = "invoice.created")]
        InvoiceCreated,
        [EnumMember(Value = "invoice.updated")]
        InvoiceUpdated,
        [EnumMember(Value = "invoice.paid")]
        InvoicePaid,
        [EnumMember(Value = "invoice.payment_failed")]
        InvoicePaymentFailed,
        [EnumMember(Value = "invoice.canceled")]
        InvoiceCanceled,

        // Charge
        [EnumMember(Value = "charge.created")]
        ChargeCreated,
        [EnumMember(Value = "charge.updated")]
        ChargeUpdated,
        [EnumMember(Value = "charge.paid")]
        ChargePaid,
        [EnumMember(Value = "charge.payment_failed")]
        ChargePaymentFailed,
        [EnumMember(Value = "charge.refunded")]
        ChargeRefunded,
        [EnumMember(Value = "charge.pending")]
        ChargePending,
        [EnumMember(Value = "charge.underpaid")]
        ChargeUnderpaid,
        [EnumMember(Value = "charge.overpaid")]
        ChargeOverpaid,
        [EnumMember(Value = "charge.partial_canceled")]
        ChargePartialCanceled,

        // Usage
        [EnumMember(Value = "usage.created")]
        UsageCreated,
        [EnumMember(Value = "usage.deleted")]
        UsageDeleted,

        // Recipient
        [EnumMember(Value = "recipient.created")]
        RecipientCreated,
        [EnumMember(Value = "recipient.deleted")]
        RecipientDeleted,
        [EnumMember(Value = "recipient.updated")]
        RecipientUpdated,

        // BankAccount
        [EnumMember(Value = "bank_account.created")]
        BankAccountCreated,
        [EnumMember(Value = "bank_account.updated")]
        BankAccountUpdated,
        [EnumMember(Value = "bank_account.deleted")]
        BankAccountDeleted
    }
}
