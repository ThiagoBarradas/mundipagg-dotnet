using System;
using System.Runtime.Serialization;

namespace Mundipagg.Utils
{
    /// <summary>
    /// Enum utility
    /// </summary>
    public static class EnumUtil
    {
        /// <summary>
        /// Get value of enum member attribute
        /// </summary>
        /// <param name="enumVal">Enum value</param>
        /// <returns>Content of EnumMember attribute</returns>
        public static string GetEnumMember(this Enum enumVal)
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false);

            if (attributes.Length > 0)
            {
                EnumMemberAttribute enumMember = (EnumMemberAttribute)attributes[0];
                return enumMember.Value;
            }

            return null;
        }
    }
}