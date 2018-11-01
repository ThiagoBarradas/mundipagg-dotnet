using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetSellerResponse 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public GetAddressResponse Address { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public string DeletedAt { get; set; }
    }
} 