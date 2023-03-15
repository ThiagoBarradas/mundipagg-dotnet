using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    public enum ProviderNameEnum
    {
        [EnumMember(Value = "gateway")]
        Gateway,

        [EnumMember(Value = "psp")]
        Psp,

        [EnumMember(Value = "simulator")]
        Simulator,
    }
}
