namespace mas.Infra.EntityConfiguration
{
    public class TradingFeeItemEntityConfiguration : IEntityTypeConfiguration<TradingFeeItem>
    {
        public void Configure(EntityTypeBuilder<TradingFeeItem> builder)
        {
            builder.ToTable("TradingFeeItems");
            builder.HasKey(x => x.Id);
        }
    }
}
