namespace Mundipagg.Models.Request
{
    public class CreateIncrementRequest
    {
        #region Public Properties

        public int? Cycles { get; set; }

        public string Description { get; set; }

        public string IncrementType { get; set; }

        public string ItemId { get; set; }

        public double Mvalue { get; set; }

        #endregion Public Properties
    }
}