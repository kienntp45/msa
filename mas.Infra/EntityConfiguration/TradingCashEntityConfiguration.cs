namespace mas.Infra.EntityConfiguration
{
    public class TradingCashEntityConfiguration : IEntityTypeConfiguration<TradingCash>
    {
        public void Configure(EntityTypeBuilder<TradingCash> builder)
        {
            builder.ToTable("TradingCashs");
            builder.HasKey(t => t.Id);

        }
    }
}
