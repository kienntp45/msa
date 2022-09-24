namespace msa.App.Mappings
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<UpdateTradingCashCommand, TradingCash>().ReverseMap();
            CreateMap<TradingFeeItemModifiedDomainEvent, TradingFeeItem>().ReverseMap();
        }
    }
}
