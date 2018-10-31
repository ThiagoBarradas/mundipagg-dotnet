using MundiPagg.Models.Enums;

namespace MundiPagg.Models
{
    /// <summary>
    /// Split model
    /// </summary>
    public class Split
    {
        /// <summary>
        /// Split type
        /// </summary>
        public SplitTypeEnum Type { get; set; }

        /// <summary>
        /// Splitted amount
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        public Recipient Recipient { get; set; }
    }
}
