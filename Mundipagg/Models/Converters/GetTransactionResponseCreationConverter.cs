using Mundipagg.Models.Response;

namespace Mundipagg.Models.Converters
{
    internal class GetTransactionResponseCreationConverter : JsonCreationConverter<GetTransactionResponse>
    {
        public GetTransactionResponseCreationConverter()
        {
            typeName = "transaction_type";
            dic = new System.Collections.Generic.Dictionary<string, System.Type>()
            {
                { "voucher",typeof(GetVoucherTransactionResponse)},
                { "bank_transfer",typeof(GetBankTransferTransactionResponse)},
                { "safetypay",typeof(GetSafetyPayTransactionResponse)},
                { "boleto",typeof(GetBoletoTransactionResponse)},
                { "pix",typeof(GetPixTransactionResponse)},
                { "debit_card",typeof(GetDebitCardTransactionResponse)},
                { "cash",typeof(GetCashTransactionResponse)},
                { "credit_card",typeof(GetCreditCardTransactionResponse)},
                { "private_label",typeof(GetPrivateLabelTransactionResponse)}
            };
        }
    }
}