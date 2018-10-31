using System.Runtime.Serialization;

namespace MundiPagg.Models.Enums
{
    /// <summary>
    /// Recipient status enum
    /// </summary>
    public enum RecipientStatusEnum
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
    }
}
