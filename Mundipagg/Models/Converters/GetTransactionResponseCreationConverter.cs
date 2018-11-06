namespace Mundipagg.Models.Converters
{
    internal class GetTransactionResponseCreationConverter : JsonCreationConverter<GetTransactionResponse>
    {
        #region Public Constructors

        public GetTransactionResponseCreationConverter()
        {
            typeName = "transaction_type";
            dic = new System.Collections.Generic.Dictionary<string, System.Type>()
            {
                { "voucher",typeof(GetVoucherTransactionResponse)},
                { "bank_transfer",typeof(GetBankTransferTransactionResponse)},
                { "safetypay",typeof(GetSafetyPayTransactionResponse)},
                { "boleto",typeof(GetBoletoTransactionResponse)},
                { "debit_card",typeof(GetDebitCardTransactionResponse)},
                { "cash",typeof(GetCashTransactionResponse)},
                { "credit_card",typeof(GetCreditCardTransactionResponse)},
            };
        }

        #endregion Public Constructors
    }
}