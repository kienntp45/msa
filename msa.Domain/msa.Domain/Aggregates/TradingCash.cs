namespace msa.Domain.Aggregates
{
    public class TradingCash: BaseEntity
    {
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
        public TradingCash( string clientCode, long cashAmount, long advance, long remainSecuritiesPower, long fSavingPower, long adhoc, long matchedBuy, long pendingBuy, long intradayDebt, long pendingBuyDebt, long matchedBuyFee, long pendingBuyFee, long internalTransfer, long externalTransfer, long feeSum, long creditLine, long remainDebt, long debtInterest, long receivableT0, long receivableT1, long receivableT2, long receivableDividend, long receivableMatureCW, long receivableOddlot, long fSaving, long fSavingForPower, long bankSaving)
        {
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

        public void UpdateTradingCashStarted(TradingCashModifiedDomainEvent tradingCash )
        {
            var TradingCashModifiedDomainEvent = new TradingCashModifiedDomainEvent(tradingCash.Id, tradingCash.ClientCode, tradingCash.CashAmount, tradingCash.Advance, tradingCash.RemainSecuritiesPower, tradingCash.FSavingPower, tradingCash.Adhoc, tradingCash.MatchedBuy, tradingCash.PendingBuy, tradingCash.IntradayDebt, tradingCash.PendingBuyDebt, tradingCash.MatchedBuyFee, tradingCash.PendingBuyFee, tradingCash.InternalTransfer, tradingCash.ExternalTransfer, tradingCash.FeeSum, tradingCash.CreditLine, tradingCash.RemainDebt, tradingCash.DebtInterest, tradingCash.ReceivableT0, tradingCash.ReceivableT1, tradingCash.ReceivableT2, tradingCash.ReceivableDividend, tradingCash.ReceivableMatureCW, tradingCash.ReceivableOddlot, tradingCash.FSaving, tradingCash.FSavingForPower, tradingCash.BankSaving);
            this.AddDomainEvent(TradingCashModifiedDomainEvent);
            Apply(TradingCashModifiedDomainEvent);
        }
        public long AddCashAmount(long cashAmount)
        {
            return this.CashAmount +=cashAmount;
        }
        private void Apply(TradingCashModifiedDomainEvent @event)
        {
            Id = @event.Id;
           ClientCode = @event.ClientCode;
            CashAmount = @event.CashAmount;
            Advance = @event.Advance;
            RemainSecuritiesPower = @event.RemainSecuritiesPower;
            FSavingPower = @event.FSavingPower;
            Adhoc = @event.Adhoc;
            MatchedBuy = @event.MatchedBuy;
            PendingBuy = @event.PendingBuy;
            IntradayDebt = @event.IntradayDebt;
            PendingBuyDebt = @event.PendingBuyDebt;
            MatchedBuyFee = @event.MatchedBuyFee;
            PendingBuyFee = @event.PendingBuyFee;
            InternalTransfer = @event.InternalTransfer;
            ExternalTransfer = @event.ExternalTransfer;
            FeeSum = @event.FeeSum;
            CreditLine = @event.CreditLine;
            RemainDebt = @event.RemainDebt;
            DebtInterest = @event.DebtInterest;
            ReceivableT0 = @event.ReceivableT0;
            ReceivableT1 = @event.ReceivableT1;
            ReceivableT2 = @event.ReceivableT2;
            ReceivableDividend = @event.ReceivableDividend;
            ReceivableMatureCW = @event.ReceivableMatureCW;
            ReceivableOddlot = @event.ReceivableOddlot;
            FSaving = @event.FSaving;
            FSavingForPower = @event.FSavingForPower;
            BankSaving = @event.BankSaving;
        }
    }
}
