using System.Collections.Generic;
using Mundipagg.Models.Request;
using Mundipagg.Models.Webhooks;
using Newtonsoft.Json;
using PagarMe.Models.Request;

namespace Mundipagg.ConsoleTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var jsonn = "{ \"type\" : \"order.created\", \"data\" : { \"id\" : \"asdsads\" } }";

            var testew = JsonConvert.DeserializeObject<WebhookReceived>(jsonn);

            Configuration config = new Configuration
            {
                AccountManagementKey = "amk",
                MpToken = "token",
                SecretKey = "sk",
                RequestKey = "rk",
                ApiUrl = "https://stgapi.mundipagg.com/core/v1"
            };

            IMundipaggApiClient client = new MundipaggApiClient(config);

            var createOrderRequest = new CreateOrderRequest
            {
                Items = new List<CreateOrderItemRequest>
                {
                    new CreateOrderItemRequest
                    {
                        Amount = 5000,
                        Code = "12345",
                        Quantity = 1,
                        Description = "It just works"
                    }
                },

                Customer = new CreateCustomerRequest
                {
                    Name = "Test da Silva",
                    Document = "80487236033",
                    Email = "teste@testando.com",
                    Type = "individual",
                    Phones = new CreatePhonesRequest
                    {
                        HomePhone = new CreatePhoneRequest
                        {
                            AreaCode = "21",
                            CountryCode = "55",
                            Number = "12344321"
                        }
                    }
                },

                Payments = new List<CreatePaymentRequest>
                {
                    new CreatePaymentRequest
                    {
                        Amount = 5000,
                        PaymentMethod = "private_label",
                        PrivateLabel = new CreatePrivateLabelPaymentRequest
                        {
                            Capture = true,
                            Installments = 1,
                            StatementDescriptor = "No Quarter",
                            Card = new CreateCardRequest
                            {
                                Number = "4000000000000010",
                                Cvv = "123",
                                ExpMonth = 12,
                                ExpYear = 2030,
                                Brand = "elo",
                                Label = "Pernambucanas",
                                HolderName = "Teste Da Silva",
                                HolderDocument = "80487236033"
                            }
                        }
                    }
                }
            };
            var createOrderResponse = client.Order.CreateOrder("idempotency-key", createOrderRequest);
            System.Console.WriteLine(createOrderResponse);

            //Create recipient request with code
            var recipientRequest = new CreateRecipientRequest()
            {
                DefaultBankAccount = new CreateBankAccountRequest()
                {
                    Bank = "341",
                    AccountNumber = "1234",
                    BranchNumber = "123",
                    HolderDocument = "61918615756" ,
                    HolderName = "moises",
                    HolderType = "individual",
                    AccountCheckDigit = "7",
                    BranchCheckDigit = "7",
                    Type = "checking"
                },
                Document = "61918615756",
                Description = "Nao Consegue",
                Name = "Moises",
                Code = "mnc_04",
                Type = "individual",
            };

            var recipient = client.Recipient.CreateRecipient(recipientRequest);

            // Get recipient By Code
            var recipientResponse = client.Recipient.GetRecipientByCode(recipient.Data.Code);

            //CreatePixOrder
            // var createPixOrder = new CreateOrderRequest
            // {
            //     AntifraudEnabled = false,
            //     Closed = false,
            //     Code = "or_123",
            //     Currency = "BRL",
            //     Customer = new CreateCustomerRequest()
            //     {
            //         Name = "teste1hj",
            //         Email = "teste1hj@gmail.com",
            //         Document = "12345678978",
            //         Type = "individual",
            //         Phones = new CreatePhonesRequest()
            //         {
            //             HomePhone = new CreatePhoneRequest()
            //             {
            //                 AreaCode = "22",
            //                 CountryCode = "55",
            //                 Number = "12345678"
            //             }
            //         }
            //     },
            //     CustomerId = null,
            //     Device = new CreateDeviceRequest(),
            //     Ip = null,
            //     Items = new List<CreateOrderItemRequest>
            //     {
            //         new CreateOrderItemRequest
            //         {
            //             Amount = 10000,
            //             Category = "beleza",
            //             Code = "pro_123",
            //             Description = "maquiagem",
            //             Quantity = 1,
            //             Seller = null,
            //             SellerId = null
            //         }
            //     },
            //     Location = null,
            //     Metadata = new Dictionary<string, string>(),
            //     Payments = new List<CreatePaymentRequest>()
            //     {
            //         new CreatePaymentRequest
            //         {
            //             Amount = 10000,
            //             BankTransfer = null,
            //             Boleto = null,
            //             Pix = new CreatePixPaymentRequest
            //             {
            //                 ExpiresAt = null,
            //                 ExpiresIn = 600,
            //                 AdditionalInformation = new List<PixAdditionalInformation>()
            //                 {
            //                     new PixAdditionalInformation()
            //                     {
            //                         Name = "Mensagem",
            //                         Value = "Esta é uma mensagem do Pix"
            //                     }
            //                 }
            //             },
            //             Cash = null,
            //             Checkout = null,
            //             CreditCard = null,
            //             Customer = null,
            //             CustomerId = null,
            //             DebitCard = null,
            //             GatewayAffiliationId = "123",
            //             Metadata = null,
            //             PaymentMethod = "pix",
            //             Split = null,
            //             Voucher = null
            //         }
            //     },
            //     SessionId = "123",
            //     Shipping = null
            // };

            //CreateCheckoutPixOrder
            // var createCheckoutPixOrder = new CreateOrderRequest
            // {
            //     AntifraudEnabled = false,
            //     Closed = false,
            //     Code = "or_123",
            //     Currency = "BRL",
            //     Customer = new CreateCustomerRequest()
            //     {
            //         Name = "teste1hj",
            //         Email = "teste1hj@gmail.com",
            //         Document = "12345678978",
            //         Type = "individual",
            //         Phones = new CreatePhonesRequest()
            //         {
            //             HomePhone = new CreatePhoneRequest()
            //             {
            //                 AreaCode = "22",
            //                 CountryCode = "55",
            //                 Number = "12345678"
            //             }
            //         }
            //     },
            //     CustomerId = null,
            //     Device = new CreateDeviceRequest(),
            //     Ip = null,
            //     Items = new List<CreateOrderItemRequest>
            //     {
            //         new CreateOrderItemRequest
            //         {
            //             Amount = 10000,
            //             Category = "beleza",
            //             Code = "pro_123",
            //             Description = "maquiagem",
            //             Quantity = 1,
            //             Seller = null,
            //             SellerId = null
            //         }
            //     },
            //     Location = null,
            //     Metadata = new Dictionary<string, string>(),
            //     Payments = new List<CreatePaymentRequest>()
            //     {
            //         new CreatePaymentRequest
            //         {
            //             Amount = 10000,
            //             BankTransfer = null,
            //             Boleto = null,
            //             Pix = null,
            //             Cash = null,
            //             Checkout = new CreateCheckoutPaymentRequest
            //             {
            //                 AcceptedMultiPaymentMethods = null,
            //                 AcceptedPaymentMethods = new List<string>{"pix"},
            //                 AcceptedBrands = null,
            //                 BankTransfer = null,
            //                 BillingAddress = null,
            //                 BillingAddressEditable = false,
            //                 Boleto = null,
            //                 CreditCard = null,
            //                 Voucher = null,
            //                 CustomerEditable = null,
            //                 DebitCard = null,
            //                 Pix = new CreateCheckoutPixPaymentRequest
            //                 {
            //                     ExpiresAt = null,
            //                     ExpiresIn = 600,
            //                     AdditionalInformation = new List<PixAdditionalInformation>()
            //                     {
            //                         new PixAdditionalInformation()
            //                         {
            //                             Name = "Mensagem",
            //                             Value = "Esta é uma mensagem do checkout"
            //                         }
            //                     }
            //                 },
            //                 DefaultPaymentMethod = "Pix",
            //                 ExpiresIn = 900,
            //                 GatewayAffiliationId = null,
            //                 SkipCheckoutSuccessPage = false,
            //                 SuccessUrl = null
            //             },
            //             CreditCard = null,
            //             Customer = null,
            //             CustomerId = null,
            //             DebitCard = null,
            //             GatewayAffiliationId = "123",
            //             Metadata = null,
            //             PaymentMethod = "checkout",
            //             Split = null,
            //             Voucher = null
            //         }
            //     },
            //     SessionId = "123",
            //     Shipping = null
            // };

            // client.UpdateConfiguration(secretKey: "sk_test_WoE1e30U9YIAvM9R");
            // var createPixResult = client.Order.CreateOrder(null, createPixOrder);
            // var createPixResult = client.Order.CreateOrder(null, createCheckoutPixOrder);
            //
            // var teste = createPixResult.Data;

            #region CreateNetworkTokenOrder
            var createNetworkTokenOrder = new CreateOrderRequest()
            {
                AntifraudEnabled = false,
                Customer = new CreateCustomerRequest()
                {
                    Name = "teste",
                    Email = "teste@teste.com",
                    Document = "12345678978",
                    Type = "individual",
                    Phones = new CreatePhonesRequest()
                    {
                        HomePhone = new CreatePhoneRequest()
                        {
                            AreaCode = "22",
                            CountryCode = "55",
                            Number = "12345678"
                        }
                    }
                },
                Items = new List<CreateOrderItemRequest>
                {
                    new CreateOrderItemRequest
                    {
                        Amount = 10000,
                        Category = "beleza",
                        Code = "pro_123",
                        Description = "maquiagem",
                        Quantity = 1,
                        Seller = null,
                        SellerId = null
                    }
                },
                Payments = new List<CreatePaymentRequest>()
                {
                    new CreatePaymentRequest
                    {
                        GatewayAffiliationId = "merchantkey",
                        Amount = 10000,
                        CreditCard = new CreateCreditCardPaymentRequest
                        {
                            Authentication = null,
                            Capture = false,
                            NetworkToken = new CreateNetworkTokenRequest
                            {
                                Cryptograms =  new List<string>
                                {
                                    "ANfQt43bddROAAEnSAMhAAADFA===="
                                },
                                Number = "5256621004565548",
                                BillingAddress = new NetworkTokenAddress
                                {
                                    City = "Malibu",
                                    Country = "US",
                                    Neighborhood = "Central Malibu",
                                    Number = "10880",
                                    State = "CA",
                                    Street = "Malibu Point",
                                    ZipCode = "90265"
                                },
                                ExpMonth = 12,
                                ExpYear = 23,
                                HolderName = "Tony Stark",
                                TokenRequestorId = "50110540444",
                            }
                        },
                        PaymentMethod = "credit_card",
                        Metadata =  new Dictionary<string, string>
                        {
                            {
                                "mundipagg_payment_method_code", "19"
                            }
                        }
                    },
                },
                SessionId = "123",
                Shipping = null
            };

            client.UpdateConfiguration(secretKey:"sk_test_");

            //var networkTokenOrderResult = client.Order.CreateOrder(null, createNetworkTokenOrder);
            //var resultNetworkTokenOrderResult = networkTokenOrderResult.Data;
            #endregion

            // var r = client.Recipient.GetRecipient("rp_xxx");
            // var r1 = client.Recipient.ListRecipients(new ListRecipientsRequest { Page = 1, Size = 2 });
            // var r2 = client.Recipient.ListRecipients(new ListRecipientsRequest { Page = 2, Size = 1 });
            //
            // var result = client.Merchant.CreateMerchant(new CreateMerchantRequest { Name = "asd" });
            // var result1 = client.Account.CreateAccount(new CreateAccountRequest { Name = "asd" });
            //
            // //client.SetSecretKey("sk_test_xxx", "acc_xpto", "merch_xpto", "requestkeyyy");
            //
            // client.Charge.CreateCharge("idempotency-key", new CreateChargeRequest());
            //
            // client.Charge.CancelCharge("idempotency-key", "ch_id");
            //
            // client.Order.CreateOrder("idempotency-key", new CreateOrderRequest());
            //
            // // Capture
            // var captureRequest = new CreateCaptureChargeRequest()
            // {
            //     Amount = 100,
            //     Code = null
            // };
            //
            // client.Charge.CaptureCharge("idempotencyKey", "ch_id", captureRequest);
            //
            // // Create
            // var createRequest = new CreateCustomerRequest()
            // {
            //     Name = "teste1hj",
            //     Email = "teste1hj@gmail.com"
            // };
            // var createResult = client.Customer.CreateCustomer(createRequest);
            //
            // //client.Charge.CreateCharge()
            // // Create
            // var createRequest2 = new CreateCustomerRequest()
            // {
            //     Name = "teste2hj",
            //     Email = "teste2hj@gmail.com"
            // };
            // var createResult2 = client.Customer.CreateCustomer(createRequest2);
            //
            // //createResult.
            //
            // // Get1
            // var getResult1 = client.Customer.GetCustomer(createResult.Data.Id);
            //
            // // Update
            // var updateRequest = new UpdateCustomerRequest()
            // {
            //     Email = "xxxx@gmail.com",
            //     Name = "Testeeadsadasdasd"
            // };
            // var updateResult = client.Customer.UpdateCustomer(createResult.Data.Id, updateRequest);
            //
            // // Get2
            // var getResult2 = client.Customer.GetCustomer(updateResult.Data.Id);
            //
            // // List
            // var listRequest = new ListCustomersRequest()
            // {
            //     Size = 5
            // };
            // var listResult = client.Customer.ListCustomers(listRequest);
            //
            // var json = "{\r\n  \"id\": \"hook_eNKaMDbtQ2C7z72P\",\r\n  \"account\": {\r\n    \"id\": \"acc_gKD7oA6kIltG45V0\",\r\n    \"name\": \"App Teste Hub - Sandbox\"\r\n  },\r\n  \"type\": \"customer.created\",\r\n  \"created_at\": \"2017-09-28T05:40:50\",\r\n  \"data\": {\r\n    \"id\": \"cus_68ZVrjvfQtJoV97N\",\r\n    \"name\": \"asdasd\",\r\n    \"email\": \"asdas@mailinator.com\",\r\n    \"delinquent\": false,\r\n    \"created_at\": \"2017-09-28T05:40:50\",\r\n    \"updated_at\": \"2017-09-28T05:40:50\",\r\n    \"phones\": {}\r\n  }\r\n}";
            // var hookParsed = client.Webhook.ParseWebhook(json);
            //
            // var obj = hookParsed.Data;

            //Mundipagg.IApiClient client = new ApiClient("sk_test_4GANDgoinHgDJ0VX");

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