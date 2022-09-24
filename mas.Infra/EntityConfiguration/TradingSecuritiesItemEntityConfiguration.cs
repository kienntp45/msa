namespace mas.Infra.EntityConfiguration
{
    public class TradingSecuritiesItemEntityConfiguration : IEntityTypeConfiguration<TradingSecuritiesItem>
    {
        public void Configure(EntityTypeBuilder<TradingSecuritiesItem> builder)
        {
            builder.ToTable("TradingSecuritiesItem");
            builder.HasKey(t => t.Id);
        }
    }
}
