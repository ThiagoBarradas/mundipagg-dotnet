using System.Runtime.Serialization;

namespace Mundipagg.Models.Enums
{
    public enum PaymentProviderEnum
    {
        [EnumMember(Value = "mundipagg")]
        Mundipagg,

        [EnumMember(Value = "pagarme")]
        Pagarme,
    }
}
