using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateAccountRequest
    {
        public string Name { get; set; }

        public string TimeZone { get; set; }

        public string DefaultCurrency { get; set; }

        public string Status { get; set; }

        public string[] Domains { get; set; }

        public string[] AllowedIps { get; set; }

        public UpdateAntifraudSettingsRequest AntifraudSettings { get; set; }

        public UpdateMundiPaggSettingsRequest MundipaggSettings { get; set; }

        public UpdatePagarmeSettingsRequest PagarmeSettings { get; set; }

        public UpdateCreditCardSettingsRequest CreditCardSettings { get; set; }

        public UpdateDebitCardSettingsRequest DebitCardSettings { get; set; }

        public UpdateVoucherSettingsRequest VoucherSettings { get; set; }

        public UpdateBankTransferSettingsRequest BankTransferSettings { get; set; }

        public UpdateWalletSettingsRequest WalletSettings { get; set; }

        public UpdateSafetyPaySettingsRequest SafetypaySettings { get; set; }

        public UpdateBoletoSettingsRequest BoletoSettings { get; set; }

        public UpdateFacebookSettingsRequest FacebookSettings { get; set; }

        public UpdateGeneralSettingsRequest GeneralSettings { get; set; }

        public UpdateWebhookSettingsRequest[] WebhookSettings { get; set; }

        public UpdateMerchantSettingsRequest MerchantSettings { get; set; }

        public UpdateSplitSettingsRequest SplitSettings { get; set; }

        public UpdateSubscriptionSettingsRequest SubscriptionSettings { get; set; }

        public UpdateOrderSettingsRequest OrderSettings { get; set; }

        public UpdateNotificationSettingsRequest NotificationSettings { get; set; }

        public UpdateGuaranteedCancellationSettingsRequest GuaranteedCancellationSettings { get; set; }

        public UpdateRenewCardSettingsRequest RenewCardSettings { get; set; }

        public UpdateCashSettingsRequest CashSettings { get; set; }

        public UpdateCheckoutSettingsRequest CheckoutSettings { get; set; }

        public UpdateAttemptSettingsRequest AttemptSettings { get; set; }
    }

}