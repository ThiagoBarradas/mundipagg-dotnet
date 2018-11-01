namespace Mundipagg.Models
{
    public class CreateCardTokenRequest 
    {
        public string Number { get; set; }
        public string HolderName { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Cvv { get; set; }
        public string Brand { get; set; }
    }
} 