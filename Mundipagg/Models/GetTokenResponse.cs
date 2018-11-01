using System;


namespace Mundipagg.Models
{
    public class GetTokenResponse 
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ExpiresAt { get; set; }
        public GetCardTokenResponse Card { get; set; }
    }
} 