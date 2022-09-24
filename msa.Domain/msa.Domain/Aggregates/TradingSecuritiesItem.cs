namespace msa.Domain.Aggregates
{
    public class TradingSecuritiesItem: BaseEntity
    {
        public string StockCode { get; init; }
        public string ClientCode { get; init; }
        public long TradingAvail { get; set; }
        public long TradingAvail_Mar { get; set; }
        public long PendingSell { get; set; }
        public long PendingSell_Mar { get; set; }
        public long MatchedSellIntraday { get; set; }
        public long MatchedSellIntraday_Mar { get; set; }
        public long Dividend { get; set; }
        public long Restricted { get; set; }
        public long MortgageAtBank { get; set; }
        public long Holding { get; set; }
        public long ESOP { get; set; }
        public long MarproSuspend { get; set; }
        public long MatchedBuyIntraday { get; set; }
        public long ReceivableT1 { get; set; }
        public long ReceivableT2 { get; set; }
        public long ReceivableRight { get; set; }
        public long RestrictedWaiting { get; set; }
        public long MortgageAtBankWaiting { get; set; }
        public long HoldingWaiting { get; set; }
        public long TradingWaiting { get; set; }
        public long WaitingFromCustody { get; set; }
        public long ESOPWaiting { get; set; }
        public long OddlotSellIntraday { get; set; }

        public TradingSecuritiesItem(int id,string stockCode, string clientCode, long tradingAvail, long tradingAvail_Mar, long pendingSell, long pendingSell_Mar, long matchedSellIntraday, long matchedSellIntraday_Mar, long dividend, long restricted, long mortgageAtBank, long holding, long eSOP, long marproSuspend, long matchedBuyIntraday, long receivableT1, long receivableT2, long receivableRight, long restrictedWaiting, long mortgageAtBankWaiting, long holdingWaiting, long tradingWaiting, long waitingFromCustody, long eSOPWaiting, long oddlotSellIntraday)
        {
            Id = id;
            StockCode = stockCode;
            ClientCode = clientCode;
            TradingAvail = tradingAvail;
            TradingAvail_Mar = tradingAvail_Mar;
            PendingSell = pendingSell;
            PendingSell_Mar = pendingSell_Mar;
            MatchedSellIntraday = matchedSellIntraday;
            MatchedSellIntraday_Mar = matchedSellIntraday_Mar;
            Dividend = dividend;
            Restricted = restricted;
            MortgageAtBank = mortgageAtBank;
            Holding = holding;
            ESOP = eSOP;
            MarproSuspend = marproSuspend;
            MatchedBuyIntraday = matchedBuyIntraday;
            ReceivableT1 = receivableT1;
            ReceivableT2 = receivableT2;
            ReceivableRight = receivableRight;
            RestrictedWaiting = restrictedWaiting;
            MortgageAtBankWaiting = mortgageAtBankWaiting;
            HoldingWaiting = holdingWaiting;
            TradingWaiting = tradingWaiting;
            WaitingFromCustody = waitingFromCustody;
            ESOPWaiting = eSOPWaiting;
            OddlotSellIntraday = oddlotSellIntraday;
        }
    }
}
