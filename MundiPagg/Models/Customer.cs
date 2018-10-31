using MundiPagg.Models.Enums;
using System;
using System.Collections.Generic;

namespace MundiPagg.Models
{
    /// <summary>
    /// Customer model
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Customer email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Buyer reference code in store system
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Customer birthdate
        /// </summary>
        public DateTime? Birthdate { get; set; }

        /// <summary>
        /// Customer type - Possible values ​​are Individual and Company
        /// </summary>
        public CustomerTypeEnum Type { get; set; }

        /// <summary>
        /// Facebook customer code
        /// </summary>
        public int FbId { get; set; }

        /// <summary>
        /// Facebook access token. Used to make Graph API calls and retrieve user information
        /// </summary>
        public string FbAccessToken { get; set; }

        /// <summary>
        /// Customer document
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Customer Phones
        /// </summary>
        public Phones Phones { get; set; }

        /// <summary>
        /// Customer additional information
        /// </summary>
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Customer address
        /// </summary>
        public Address Address { get; set; }
    }
}