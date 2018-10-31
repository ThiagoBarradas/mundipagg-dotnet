using Mundipagg.Utils;
using Xunit;

namespace Mundipagg.Tests.Util
{
    public class StringUtilTest
    {
        [Fact]
        public void Should_Transform_String_To_SnakeCase()
        {
            // Arrange
            var text = "AnExample";

            // Act
            var result = StringUtil.ToSnakeCase(text);

            // Assert
            Assert.Equal("an_example", result);
        }
    }
}
