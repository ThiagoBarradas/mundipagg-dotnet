using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    /// <summary>
    /// Payment method type enum
    /// </summary>
    public enum PaymentMethodTypeEnum
    {
        [EnumMember(Value = "credit_card")]
        CreditCard,

        [EnumMember(Value = "debit_card")]
        DebitCard,

        [EnumMember(Value = "private_label")]
        PrivateLabel,

        [EnumMember(Value = "checkout")]
        Checkout,

        [EnumMember(Value = "cash")]
        Cash,

        [EnumMember(Value = "boleto")]
        Boleto,

        [EnumMember(Value = "bank_transfer")]
        BankTransfer,

        [EnumMember(Value = "safetypay")]
        SafetyPay,

        [EnumMember(Value = "voucher")]
        Voucher
    }
}