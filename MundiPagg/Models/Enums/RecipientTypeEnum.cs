using System.Runtime.Serialization;

namespace MundiPagg.Models.Enums
{
    /// <summary>
    /// Recipient type enum
    /// </summary>
    public enum RecipientTypeEnum
    {
        [EnumMember(Value = "individual")]
        Individual,
        [EnumMember(Value = "company")]
        Company
    }
}
