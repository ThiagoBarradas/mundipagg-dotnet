namespace Mundipagg.Models
{
    public class GetThreeDSecureResponse 
    {
        public string Mpi { get; set; }
        public string Eci { get; set; }
        public string Cavv { get; set; }
        public string TransactionId { get; set; }
        public string SuccessUrl { get; set; }
    }
} 