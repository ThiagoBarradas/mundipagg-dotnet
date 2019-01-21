using System;

namespace Mundipagg.Models.Response
{
    public class GetAccessTokenResponse
    {

        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public string Id { get; set; }

        public string Status { get; set; }

    }
}