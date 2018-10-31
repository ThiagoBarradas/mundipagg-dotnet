using MundiPagg.Models.Enums;

namespace MundiPagg.Models
{
    /// <summary>
    /// Address model
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Complement
        /// </summary>
        public string Complement { get; set; }

        /// <summary>
        /// Zip/Postal code
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Neighborhood
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State / Province / Region (ISO 3166-2)
        /// https://en.wikipedia.org/wiki/ISO_3166-2
        /// </summary>
        public string State{ get; set; }

        /// <summary>
        /// Country (ISO 3166-1 alpha-2)
        /// https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public AddressStatusEnum Status { get; set; }
    }
}
