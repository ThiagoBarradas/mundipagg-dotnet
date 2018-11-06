namespace Mundipagg.Models.Request
{
    public class ListCustomersRequest : BaseListRequest
    {
        #region Properties

        public string Code { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        #endregion Properties
    }
}