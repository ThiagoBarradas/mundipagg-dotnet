using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    /// <summary>
    /// Customer type enum
    /// </summary>
    public enum CustomerTypeEnum
    {
        [EnumMember(Value = "individual")]
        Individual,

        [EnumMember(Value = "company")]
        Company
    }
}