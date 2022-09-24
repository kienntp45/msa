namespace msa.app3.Models
{
    public class TradingCash
    {
        public int Id { get; set; }
        public string ClientCode { get; set; }
        public long CashAmount { get; set; }
        public long Advance { get; set; }
        public long RemainSecuritiesPower { get; set; }
        public long FSavingPower { get; set; }
        public long Adhoc { get; set; }
        public long MatchedBuy { get; set; }
        public long PendingBuy { get; set; }
        public long IntradayDebt { get; set; }
        public long PendingBuyDebt { get; set; }
        public long MatchedBuyFee { get; set; }
        public long PendingBuyFee { get; set; }
        public long InternalTransfer { get; set; }
        public long ExternalTransfer { get; set; }
        public long FeeSum { get; set; }
        public long CreditLine { get; set; }
        public long RemainDebt { get; set; }
        public long DebtInterest { get; set; }
        public long ReceivableT0 { get; set; }
        public long ReceivableT1 { get; set; }
        public long ReceivableT2 { get; set; }
        public long ReceivableDividend { get; set; }
        public long ReceivableMatureCW { get; set; }
        public long ReceivableOddlot { get; set; }
        public long FSaving { get; set; }
        public long FSavingForPower { get; set; }
        public long BankSaving { get; set; }
     
        public TradingCash(int id, string clientCode, long cashAmount, long advance, long remainSecuritiesPower, long fSavingPower, long adhoc, long matchedBuy, long pendingBuy, long intradayDebt, long pendingBuyDebt, long matchedBuyFee, long pendingBuyFee, long internalTransfer, long externalTransfer, long feeSum, long creditLine, long remainDebt, long debtInterest, long receivableT0, long receivableT1, long receivableT2, long receivableDividend, long receivableMatureCW, long receivableOddlot, long fSaving, long fSavingForPower, long bankSaving)
        {
            Id = id;
            ClientCode = clientCode;
            CashAmount = cashAmount;
            Advance = advance;
            RemainSecuritiesPower = remainSecuritiesPower;
            FSavingPower = fSavingPower;
            Adhoc = adhoc;
            MatchedBuy = matchedBuy;
            PendingBuy = pendingBuy;
            IntradayDebt = intradayDebt;
            PendingBuyDebt = pendingBuyDebt;
            MatchedBuyFee = matchedBuyFee;
            PendingBuyFee = pendingBuyFee;
            InternalTransfer = internalTransfer;
            ExternalTransfer = externalTransfer;
            FeeSum = feeSum;
            CreditLine = creditLine;
            RemainDebt = remainDebt;
            DebtInterest = debtInterest;
            ReceivableT0 = receivableT0;
            ReceivableT1 = receivableT1;
            ReceivableT2 = receivableT2;
            ReceivableDividend = receivableDividend;
            ReceivableMatureCW = receivableMatureCW;
            ReceivableOddlot = receivableOddlot;
            FSaving = fSaving;
            FSavingForPower = fSavingForPower;
            BankSaving = bankSaving;
            //UpdateTradingCashStarted(id, clientCode, cashAmount, advance, remainSecuritiesPower, fSavingPower, adhoc, matchedBuy, pendingBuy, intradayDebt, pendingBuyDebt, matchedBuyFee, pendingBuyFee, internalTransfer, externalTransfer, feeSum, creditLine, remainDebt, debtInterest, receivableT0, receivableT1, receivableT2, receivableDividend, receivableMatureCW, receivableOddlot, fSaving, fSavingForPower, bankSaving);
        }
        public TradingCash()
        {

        }

      
    }
}
