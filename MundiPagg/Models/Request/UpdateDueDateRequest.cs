using System;

namespace MundiPagg.Models.Request
{
    /// <summary>
    /// Update due date request
    /// </summary>
    public class UpdateDueDateRequest
    {
        /// <summary>
        /// New due date
        /// </summary>
        public DateTime DueAt { get; set; }
    }
}
