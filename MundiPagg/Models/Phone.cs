namespace MundiPagg.Models
{
    /// <summary>
    /// Phone model
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// Country code - numeric only
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Area code - numeric only   
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// Phone number - numeric only
        /// </summary>
        public string Number { get; set; }
    }
}
