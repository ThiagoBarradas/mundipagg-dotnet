namespace Mundipagg.Models.Request
{
    public class CreateThreeDSecureRequest
    {
        #region Public Properties

        public string Cavv { get; set; }

        public string Eci { get; set; }

        public string Mpi { get; set; }

        public string SuccessUrl { get; set; }

        public string TransactionId { get; set; }

        #endregion Public Properties
    }
}