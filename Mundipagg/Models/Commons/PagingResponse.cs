namespace Mundipagg.Models.Commons
{
    /// <summary>
    /// Paging response
    /// </summary>
    /// <typeparam name="T">Response type</typeparam>
    public class PagingResponse<T>
    {
        /// <summary>
        /// Items
        /// </summary>
        public T[] Data { get; set; }

        /// <summary>
        /// Pagination info
        /// </summary>
        public Paging Paging { get; set; }

    }
}