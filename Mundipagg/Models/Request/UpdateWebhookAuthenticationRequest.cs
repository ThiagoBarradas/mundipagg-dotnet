namespace Mundipagg.Models.Request
{
    public class UpdateWebhookAuthenticationRequest
    {
        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }
    }
}
