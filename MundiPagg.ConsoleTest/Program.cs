using MundiPagg.Models;
using MundiPagg.Models.Request;
using MundiPagg.Utils;
using Newtonsoft.Json;

namespace MundiPagg.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
           var resut =  JsonConvert.SerializeObject(new
            {
                Wer_Test = "1212",
                WerTest = 12
            }, JsonSerializerUtil.LowerCaseSettings);

            var client = new ApiClient("sk_test_XXXXXXX");

            // Create
            var createRequest = new CreateCustomerRequest()
            {
                Name = "testeeee",
                Email = "testeeee@gmail.com"
            };
            var createResult = client.Customer.CreateCustomer(createRequest);


            //createResult.

            // Get1
            var getResult1 = client.Customer.GetCustomer(createResult.Data.Id);

            // Update
            var updateRequest = new UpdateCustomerRequest()
            {
                Email = "xxxx@gmail.com",
                Name = "Testeeadsadasdasd"
            };
            var updateResult = client.Customer.UpdateCustomer(createResult.Data.Id, updateRequest);

            // Get2
            var getResult2 = client.Customer.GetCustomer(updateResult.Data.Id);

            // List
            var listRequest = new ListCustomersRequest()
            {
                Size = 5
            };  
            var listResult = client.Customer.ListCustomers(listRequest);

            var json = "{\r\n  \"id\": \"hook_eNKaMDbtQ2C7z72P\",\r\n  \"account\": {\r\n    \"id\": \"acc_gKD7oA6kIltG45V0\",\r\n    \"name\": \"App Teste Hub - Sandbox\"\r\n  },\r\n  \"type\": \"customer.created\",\r\n  \"created_at\": \"2017-09-28T05:40:50\",\r\n  \"data\": {\r\n    \"id\": \"cus_68ZVrjvfQtJoV97N\",\r\n    \"name\": \"asdasd\",\r\n    \"email\": \"asdas@mailinator.com\",\r\n    \"delinquent\": false,\r\n    \"created_at\": \"2017-09-28T05:40:50\",\r\n    \"updated_at\": \"2017-09-28T05:40:50\",\r\n    \"phones\": {}\r\n  }\r\n}";
            var hookParsed = client.Webhook.ParseWebhook(json);

            var obj = hookParsed.Data;

            //MundiPagg.IApiClient client = new ApiClient("sk_test_4GANDgoinHgDJ0VX");

            //var json = "{\r\n  \"id\": \"hook_eNKaMDbtQ2C7z72P\",\r\n  \"account\": {\r\n    \"id\": \"acc_gKD7oA6kIltG45V0\",\r\n    \"name\": \"App Teste Hub - Sandbox\"\r\n  },\r\n  \"type\": \"customer.created\",\r\n  \"created_at\": \"2017-09-28T05:40:50\",\r\n  \"data\": {\r\n    \"id\": \"cus_68ZVrjvfQtJoV97N\",\r\n    \"name\": \"asdasd\",\r\n    \"email\": \"asdas@mailinator.com\",\r\n    \"delinquent\": false,\r\n    \"created_at\": \"2017-09-28T05:40:50\",\r\n    \"updated_at\": \"2017-09-28T05:40:50\",\r\n    \"phones\": {}\r\n  }\r\n}";
            //var hookParsed = client.Webhook.ParseWebhook(json);

            //var obj = hookParsed.Data;

            ////hookParsed.DataType

            //var binresult = client.Bin.GetBin("1");
            //var binresult1 = client.Bin.GetBin("442022");
            //var binresult11 = client.Bin.GetBin("002152");

            //var h1 = client.Webhook.ListWebhooks(new Models.Request.ListWebhooksRequest()
            //{   
            //    Status = Models.Enums.WebhookStatusEnum.Failed
            //});
            //var h2 = client.Webhook.RetryWebhook(h1.Data.Data[0].Id);



            //var result = client.Customer.CreateCustomer(new Models.Request.CreateCustomerRequest()
            //{
            //     Name = "testeeee",
            //     Email = "testeeee@gmail.com"
            //});

            //var result1 = client.Customer.GetCustomer(result.Data.Id);

            //var result2 = client.Customer.UpdateCustomer(result.Data.Id, new Models.Request.UpdateCustomerRequest() {
            //    Name = "Testeeadsadasdasd"
            //});

            //var result3 = client.Customer.GetCustomer(result.Data.Id);

            //var result4 = client.Customer.ListCustomers(new Models.Request.ListCustomersRequest()
            //{
            //    Size = 5
            //});
        }
    }
}
