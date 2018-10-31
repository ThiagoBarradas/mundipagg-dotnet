using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    /// <summary>
    /// Split type enum
    /// </summary>
    public enum SplitTypeEnum
    {
        [EnumMember(Value = "flat")]
        Flat,
        [EnumMember(Value = "percentage")]
        Percentage,
    }
}
