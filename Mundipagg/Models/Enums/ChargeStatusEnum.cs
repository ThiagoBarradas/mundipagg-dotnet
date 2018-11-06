using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    /// <summary>
    /// Charge status enum
    /// </summary>
    public enum ChargeStatusEnum
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "paid")]
        Paid,

        [EnumMember(Value = "canceled")]
        Canceled,

        [EnumMember(Value = "processing")]
        Processing,

        [EnumMember(Value = "failed")]
        Failed,

        [EnumMember(Value = "overpaid")]
        Overpaid,

        [EnumMember(Value = "underpaid")]
        Underpaid
    }
}