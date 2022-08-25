using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    public enum ProviderNameEnum
    {
        [EnumMember(Value = "mundipagg")]
        Mundipagg,

        [EnumMember(Value = "pagarme")]
        Pagarme,
    }
}
