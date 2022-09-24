namespace msa.Domain.Events
{

    public class TradingFeeItemModifiedDomainEvent : INotification
    {
        public int Id { get; set; }
        public string ClientCode { get; init; }
        public FeeType FeeType { get; init; }
        public long Value { get; set; }

        public TradingFeeItemModifiedDomainEvent(int id, string clientCode, FeeType feeType, long value)
        {
            Id = id;
            ClientCode = clientCode;
            FeeType = feeType;
            Value = value;
        }

        public TradingFeeItemModifiedDomainEvent()
        {

        }
    }
}