using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    /// <summary>
    /// Errors response - Is set when status code is 4XX or 5XX
    /// </summary>
    public class ErrorsResponse
    {
        #region Public Properties

        /// <summary>
        /// Errors detail per property
        /// </summary>
        public IDictionary<string, string[]> Errors { get; set; }

        /// <summary>
        /// Main error message
        /// </summary>
        public string Message { get; set; }

        #endregion Public Properties
    }
}