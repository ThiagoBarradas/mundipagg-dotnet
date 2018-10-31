using MundiPagg.Models.Enums;
using MundiPagg.Utils;
using System;
using Xunit;

namespace MundiPagg.Tests.Util
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
    }

    public class DictionaryUtilTestClass
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public CustomerTypeEnum CustomerType { get; set; }
    }
}
