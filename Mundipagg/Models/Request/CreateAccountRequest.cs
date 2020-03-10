using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateAccountRequest
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string TimeZone { get; set; }

        public string DefaultCurrency { get; set; }

        public string[] Domains { get; set; }

        public CreateMundipaggSettingsRequest MundipaggSettings { get; set; }

        public CreatePagarmeSettingsRequest PagarmeSettings { get; set; }

        public CreateBoletoSettingsRequest BoletoSettings { get; set; }

        public CreateCreditCardSettingsRequest CreditCardSettings { get; set; }

        public CreateDebitCardSettingsRequest DebitCardSettings { get; set; }

        public CreateVoucherSettingsRequest VoucherSettings { get; set; }

        public CreateFacebookSettingsRequest FacebookSettings { get; set; }

        public CreateGeneralSettingsRequest GeneralSettings { get; set; }

        public CreateWalletSettingsRequest WalletSettings { get; set; }

        public CreateSubscriptionSettingsRequest SubscriptionSettings { get; set; }

        public CreateWebhookSettingRequest[] WebhookSettings { get; set; }

        public CreateCashSettingsRequest CashSettings { get; set; }

        public CreateCheckoutSettingsRequest CheckoutSettings { get; set; }

        public CreateRenewCardSettingsRequest RenewCardSettings { get; set; }

        public CreateAntifraudSettingsRequest AntifraudSettings { get; set; }

        public CreateBankTransferSettingsRequest BankTransferSettings { get; set; }

        public CreateSafetypaySettingsRequest SafetypaySettings { get; set; }

        public CreateSplitSettingsRequest SplitSettings { get; set; }

        public CreateOrderSettingsRequest OrderSettings { get; set; }

        public CreateNotificationSettingsRequest NotificationSettings { get; set; }

        public CreateGuaranteedCancellationSettingsRequest GuaranteedCancellationSettings { get; set; }
    }

    public class CreateBoletoSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Bank { get; set; }

        public string Instructions { get; set; }

        public string Gateway { get; set; }

        public int? DueDays { get; set; }
    }

    public class CreateCashSettingsRequest
    {
        public bool Enabled { get; set; }
    }

    public class CreateCheckoutSettingsRequest
    {
        public string AddressType { get; set; }

        public bool Enabled { get; set; }

        public string[] OptionalFields { get; set; }

        public string[] RequiredFields { get; set; }
    }

    public class CreateCreditCardSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }

    public class CreateDebitCardSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }

    public class CreateVoucherSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }

    public class CreateFacebookSettingsRequest
    {
        public long AppId { get; set; }

        public string AppSecret { get; set; }

        public string[] Permissions { get; set; }
    }

    public class CreateGeneralSettingsRequest
    {
        public string DisplayName { get; set; }

        public string Theme { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string Logo { get; set; }
    }

    public class CreateMundipaggSettingsRequest
    {
        public Guid? MerchantKey { get; set; }
    }

    public class CreatePagarmeSettingsRequest
    {
        public string ApiKey { get; set; }

        public string CryptoKey { get; set; }
    }

    public class CreateRenewCardSettingsRequest
    {
        public bool RenewOnPaymentEnabled { get; set; }

        public bool ManualRenewEnabled { get; set; }
    }

    public class CreateSubscriptionSettingsRequest
    {
        public bool Enabled { get; set; }

        public bool UsageReportEnabled { get; set; }
    }

    public class CreateWalletSettingsRequest
    {
        public bool Enabled { get; set; }

        public long MaxCards { get; set; }

        public bool Shared { get; set; }
    }

    public class CreateWebhookSettingRequest
    {
        public string Url { get; set; }

        public string[] Events { get; set; }

        public string Version { get; set; }

        public long? Interval { get; set; }

        public int? MaxAttempts { get; set; }
    }

    public class CreateAntifraudSettingsRequest
    {
        public bool AutoCancel { get; set; }

        public bool AutoCapture { get; set; }
    }

    public class CreateSplitSettingsRequest
    {
        public bool Enabled { get; set; }
    }

    public class CreateBankTransferSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Bank { get; set; }

        public string Gateway { get; set; }
    }

    public class CreateNotificationSettingsRequest
    {
        public bool Enabled { get; set; }
    }

    public class CreateSafetypaySettingsRequest
    {
        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }

    public class CreateGuaranteedCancellationSettingsRequest
    {
        public bool Enabled { get; set; }
    }

    public class CreateOrderSettingsRequest
    {
        public bool MultiPaymentsEnabled { get; set; }

        public bool MultiBuyersEnabled { get; set; }

        public bool OpenOrdersEnabled { get; set; }
    }
}
