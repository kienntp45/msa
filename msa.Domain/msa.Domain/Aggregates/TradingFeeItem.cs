namespace msa.Domain.Aggregates
{
    public class TradingFeeItem: BaseEntity
    {
        public string ClientCode { get; init; }
        public FeeType FeeType { get; init; }
        public long Value { get; set; }

        public TradingFeeItem(int id,string clientCode, FeeType feeType, long value)
        {
            Id = id;
            ClientCode = clientCode;
            FeeType = feeType;
            Value = value;
        }
       
    }
    public enum FeeType
    {
        SMSFee = 1,
        VSDFee = 2,
        AdvisorSelectFee = 3
    }
  
}
