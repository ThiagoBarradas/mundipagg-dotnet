namespace Mundipagg.Models.Response
{
    public class GetThreeDSecureResponse
    {
        public string Cavv { get; set; }

        public string Eci { get; set; }

        public string Mpi { get; set; }

        public string SuccessUrl { get; set; }

        public string TransactionId { get; set; }
    }
}