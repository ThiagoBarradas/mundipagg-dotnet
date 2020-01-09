using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetAccountResponse
    {
        public string Id { get; set; }

        public string PublicKey { get; set; }

        public string SecretsKey { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string TimeZone { get; set; }

        public string DefaultCurrency { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string[] Domains { get; set; }

        public GetMundipaggSettingsResponse MundipaggSettings { get; set; }

        public GetPagarmeSettingsResponse PagarmeSettings { get; set; }
        
        public GetBoletoSettingsResponse BoletoSettings { get; set; }

        public GetCreditCardSettingsResponse CreditCardSettings { get; set; }

        public GetDebitCardSettingsResponse DebitCardSettings { get; set; }

        public GetVoucherSettingsResponse VoucherSettings { get; set; }

        public GetFacebookSettingsResponse FacebookSettings { get; set; }

        public GetGeneralSettingsResponse GeneralSettings { get; set; }

        public GetWalletSettingsResponse WalletSettings { get; set; }

        public GetSubscriptionSettingsResponse SubscriptionSettings { get; set; }

        public GetWebhookSettingResponse[] WebhookSettings { get; set; }

        public GetCashSettingsResponse CashSettings { get; set; }

        public GetCheckoutSettingsResponse CheckoutSettings { get; set; }

        public GetRenewCardSettingsResponse RenewCardSettings { get; set; }

        public GetAntifraudSettingsResponse AntifraudSettings { get; set; }

        public GetBankTransferSettingsResponse BankTransferSettings { get; set; }

        public GetSafetypaySettingsResponse SafetypaySettings { get; set; }

        public GetSplitSettingsResponse SplitSettings { get; set; }

        public GetOrderSettingsResponse OrderSettings { get; set; }

        public GetNotificationSettingsResponse NotificationSettings { get; set; }

        public GetGuaranteedCancellationSettingsResponse GuaranteedCancellationSettings { get; set; }
    }

    public class GetBoletoSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }

        public string Bank { get; set; }

        public string Instructions { get; set; }

        public string Gateway { get; set; }

        public int DueDays { get; set; }
    }

    public class GetCashSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }
    }

    public class GetCheckoutSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public string AddressType { get; set; }

        public bool Enabled { get; set; }

        public string[] OptionalFields { get; set; }

        public string[] RequiredFields { get; set; }
    }

    public class GetCreditCardSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }

    public class GetDebitCardSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }

    public class GetVoucherSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }

        public string Gateway { get; set; }
    }

    public class GetFacebookSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public long AppId { get; set; }

        public string AppSecret { get; set; }

        public string[] Permissions { get; set; }
    }

    public class GetGeneralSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public string DisplayName { get; set; }

        public string Logo { get; set; }
        
        public string Theme { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }
    }

    public class GetMundipaggSettingsResponse
    {
        public DateTime? UpdatedAt { get; set; }

        public string MerchantKey { get; set; }
    }

    public class GetPagarmeSettingsResponse
    {
        public DateTime? UpdatedAt { get; set; }

        public string ApiKey { get; set; }

        public string CryptoKey { get; set; }
    }

    public class GetRenewCardSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public bool RenewOnPaymentEnabled { get; set; }

        public bool ManualRenewEnabled { get; set; }
    }

    public class GetSubscriptionSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public bool Enabled { get; set; }

        public bool UsageReportEnabled { get; set; }
    }

    public class GetWalletSettingsResponse
    {
        public DateTime UpdatedAt { get; set; }

        public long MaxCards { get; set; }

        public bool Shared { get; set; }
    }

    public class GetWebhookSettingResponse
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Url { get; set; }

        public string Status { get; set; }

        public string Version { get; set; }

        public long? Interval { get; set; }

        public int? MaxAttempts { get; set; }

        public string[] Events { get; set; }
    }

    public class GetAntifraudSettingsResponse
    {
        public bool AutoCancel { get; set; }

        public bool AutoCapture { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class GetSplitSettingsResponse
    {
        public bool Enabled { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class GetBankTransferSettingsResponse
    {
        public bool Enabled { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class GetNotificationSettingsResponse
    {
        public bool Enabled { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class GetSafetypaySettingsResponse
    {
        public bool Enabled { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class GetGuaranteedCancellationSettingsResponse
    {
        public bool Enabled { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class GetOrderSettingsResponse
    {
        public bool MultiPaymentsEnabled { get; set; }

        public bool MultiBuyersEnabled { get; set; }

        public bool OpenOrdersEnabled { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
