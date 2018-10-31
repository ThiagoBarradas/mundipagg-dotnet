namespace MundiPagg.Models
{
    /// <summary>
    /// Pagination model
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Items total
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Previous page url
        /// </summary>
        public string Previous { get; set; }

        /// <summary>
        /// Next page url
        /// </summary>
        public string Next { get; set; }
    }
}
