using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    /// <summary>
    /// Gateway recipient status enum
    /// </summary>
    public enum GatewayRecipientStatusEnum
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "inactive")]
        Inactive,
    }
}