using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
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
        public string[] AllowedIps { get; set; }

        /// <summary>
        /// Configurações de antifraud
        /// </summary>
        public UpdateAntifraudSettingsRequest AntifraudSettings { get; set; }

        /// <summary>
        /// Configurações do One
        /// </summary>
        public UpdateMundiPaggSettingsRequest MundipaggSettings { get; set; }

        /// <summary>
        /// Configurações da Pagarme
        /// </summary>
        public UpdatePagarmeSettingsRequest PagarmeSettings { get; set; }

        /// <summary>
        /// Configurações de cartão de crédito
        /// </summary>
        public UpdateCreditCardSettingsRequest CreditCardSettings { get; set; }

        /// <summary>
        /// Configurações de cartão de débito
        /// </summary>
        public UpdateDebitCardSettingsRequest DebitCardSettings { get; set; }

        /// <summary>
        /// Configurações de voucher
        /// </summary>
        public UpdateVoucherSettingsRequest VoucherSettings { get; set; }

        /// <summary>
        /// Configurações de Transferência bancária
        /// </summary>
        public UpdateBankTransferSettingsRequest BankTransferSettings { get; set; }

        /// <summary>
        /// Configurações de wallet
        /// </summary>
        public UpdateWalletSettingsRequest WalletSettings { get; set; }

        /// <summary>
        /// Configurações de SafetyPay
        /// </summary>
        public UpdateSafetyPaySettingsRequest SafetypaySettings { get; set; }

        /// <summary>
        /// Configurações de boleto
        /// </summary>
        public UpdateBoletoSettingsRequest BoletoSettings { get; set; }

        /// <summary>
        /// Configurações do Facebook
        /// </summary>
        public UpdateFacebookSettingsRequest FacebookSettings { get; set; }

        /// <summary>
        /// Configurações gerais do modulo commerce
        /// </summary>
        public UpdateGeneralSettingsRequest GeneralSettings { get; set; }

        /// <summary>
        /// Configurações de webhook
        /// </summary>
        public UpdateWebhookSettingsRequest[] WebhookSettings { get; set; }

        /// <summary>
        /// Configurações de merchant
        /// </summary>
        public UpdateMerchantSettingsRequest MerchantSettings { get; set; }

        /// <summary>
        /// Configurações de Split
        /// </summary>
        public UpdateSplitSettingsRequest SplitSettings { get; set; }

        /// <summary>
        /// Configurações de Assinatura
        /// </summary>
        public UpdateSubscriptionSettingsRequest SubscriptionSettings { get; set; }

        /// <summary>
        /// Configurações de Pedido
        /// </summary>
        public UpdateOrderSettingsRequest OrderSettings { get; set; }

        /// <summary>
        /// Configuração de Aviso
        /// </summary>
        public UpdateNotificationSettingsRequest NotificationSettings { get; set; }

        /// <summary>
        /// Configurações de cancelamento garantido
        /// </summary>
        public UpdateGuaranteedCancellationSettingsRequest GuaranteedCancellationSettings { get; set; }

        /// <summary>
        /// Configurações de renovação de cartão
        /// </summary>
        public UpdateRenewCardSettingsRequest RenewCardSettings { get; set; }

        /// <summary>
        /// Configurações do meio de pagamento Cash
        /// </summary>
        public UpdateCashSettingsRequest CashSettings { get; set; }

        /// <summary>
        /// Configurações de checkout
        /// </summary>
        public UpdateCheckoutSettingsRequest CheckoutSettings { get; set; }
    }

}