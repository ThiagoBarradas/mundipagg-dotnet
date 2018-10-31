using Mundipagg.Utils;
using System.Runtime.Serialization;
using Xunit;

namespace Mundipagg.Tests.Util
{
    public class EnumUtilTest
    {
        [Fact]
        public void Should_Return_EnumMember()
        {
            // Arrange
            EnumUtilTestEnum enumVal = EnumUtilTestEnum.EnumWithEnumMember;

            // Act
            var enumMember = EnumUtil.GetEnumMember(enumVal);

            // Assert
            Assert.Equal("works", enumMember);
        }

        [Fact]
        public void Should_Return_Null()
        {
            // Arrange
            EnumUtilTestEnum enumVal = EnumUtilTestEnum.EnumWithoutEnumMember;

            // Act
            var enumMember = EnumUtil.GetEnumMember(enumVal);

            // Assert
            Assert.Equal(null, enumMember);
        }
    }

    enum EnumUtilTestEnum
    {
        [EnumMember(Value = "works")]
        EnumWithEnumMember,
        EnumWithoutEnumMember,
    }
}
