using System.Runtime.Serialization;

namespace MundiPagg.Models.Enums
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
