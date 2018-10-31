using System.Collections.Generic;

namespace MundiPagg.Models.Response
{
    /// <summary>
    /// Errors response - Is set when status code is 4XX or 5XX
    /// </summary>
    public class ErrorsResponse
    {
        /// <summary>
        /// Main error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Errors detail per property
        /// </summary>
        public IDictionary<string, string[]> Errors { get; set; }
    }
}
