namespace Mundipagg.Models.Request
{
    public class UpdateAccountRequest
    {
        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fuso horário
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Moeda
        /// </summary>
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Status da empresa
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Domínios
        /// </summary>
        public string[] Domains { get; set; }

        /// <summary>
        /// Lista de Ips liberados para se conectar com a API
        /// </summary>
        public string[] AllowedIps { get; set; }    }
}