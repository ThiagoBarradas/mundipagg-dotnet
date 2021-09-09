using Mundipagg.Models.Enums;
using Mundipagg.Utils;
using System;
using System.Globalization;
using Xunit;

namespace Mundipagg.Tests.Util
{
    public class DictionaryUtilTest
    {
        [Fact]
        public void Should_Parse_Object_To_Dictionary()
        {
            // Arrange
            DictionaryUtilTestClass obj = new DictionaryUtilTestClass
            {
                Name = "test",
                Age = 18,
                CustomerType = CustomerTypeEnum.Individual
            };

            // Act
            var result = DictionaryUtil.ToDictionary(obj);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal("test", result["name"]);
            Assert.Equal("18", result["age"]);
            Assert.Equal("individual", result["customer_type"]);
        }

        [Fact]
        public void Should_Throws_Exception ()
        {
            // Arrange
            DictionaryUtilTestClass obj = null;

            // Act
            var ex = Assert.Throws<ArgumentNullException>(() => DictionaryUtil.ToDictionary(obj));

            // Assert
            Assert.Equal(ex.ParamName, "source");
        }

        [Theory]
        [InlineData("11/07/2021 21:00:00", "07/11/2021 21:00:00")]
        [InlineData("2020-11-19T00:00:00", "11/19/2020 00:00:00")]
        [InlineData("01/01/2021 21:00:00", "01/01/2021 21:00:00")]
        public void Should_Convert_DateTime(string originalDate, string expectedDate)
        {
            DictionaryUtilTestClass obj = new DictionaryUtilTestClass
            {
                CreatedAt = DateTime.Parse(originalDate, new CultureInfo("pt-BR"))
            };

            // Act
            var result = DictionaryUtil.ToDictionary(obj);

            // Assert
            Assert.Equal(expectedDate, result["created_at"]);
        }
    }

    public class DictionaryUtilTestClass
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime? CreatedAt { get; set; }

        public CustomerTypeEnum CustomerType { get; set; }
    }
}
