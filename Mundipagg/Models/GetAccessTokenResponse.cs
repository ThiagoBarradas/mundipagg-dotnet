using System;


namespace Mundipagg.Models
{
    public class GetAccessTokenResponse 
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public GetCustomerResponse Customer { get; set; }
    }
}