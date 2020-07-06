namespace Mundipagg.Models.Request
{
    public class CreateWebhookAuthenticationRequest
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
