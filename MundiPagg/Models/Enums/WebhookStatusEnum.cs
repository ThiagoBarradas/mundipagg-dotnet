using System.Runtime.Serialization;

namespace MundiPagg.Models.Enums
{
    /// <summary>
    /// Webhook status enum
    /// </summary>
    public enum WebhookStatusEnum
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "sent")]
        Sent
    }
}
