namespace Mundipagg.Models.Request
{
    /// <summary>
    /// Base list request
    /// </summary>
    public abstract class BaseListRequest
    {
        #region Public Constructors

        public BaseListRequest()
        {
            this.Page = 1;
            this.Size = 10;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        public int Size { get; set; }

        #endregion Public Properties
    }
}