using Mundipagg.Models.Enums;
using Mundipagg.Utils;
using Newtonsoft.Json;
using Xunit;

namespace Mundipagg.Tests.Util
{
    public class JsonSerializerUtilTest
    {
        [Fact]
        public void Should_Parse_Json_To_SnakeCase()
        {
            // Arrange
            JsonSerializerSettings settings = JsonSerializerUtil.SnakeCaseSettings;
            var obj = new JsonSerializerUtilTestClass()
            {
                Name = "test",
                Age = 18,
                CustomerType = CustomerTypeEnum.Individual
            };

            // Act
            var jsonAsString = JsonConvert.SerializeObject(obj, settings);

            // Assert
            var expected = "{\r\n  \"name\": \"test\",\r\n  \"age\": 18,\r\n  \"customer_type\": \"individual\"\r\n}";
            Assert.Equal(expected, jsonAsString);
        }

        [Fact]
        public void Should_Parse_Json_To_CamelCase()
        {
            // Arrange
            JsonSerializerSettings settings = JsonSerializerUtil.CamelCaseSettings;
            var obj = new JsonSerializerUtilTestClass()
            {
                Name = "test",
                Age = 18,
                CustomerType = CustomerTypeEnum.Individual
            };

            // Act
            var jsonAsString = JsonConvert.SerializeObject(obj, settings);

            // Assert
            var expected = "{\r\n  \"name\": \"test\",\r\n  \"age\": 18,\r\n  \"customerType\": \"individual\"\r\n}";
            Assert.Equal(expected, jsonAsString);
        }
    }

    public class JsonSerializerUtilTestClass
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public CustomerTypeEnum CustomerType { get; set; }
    }
}
