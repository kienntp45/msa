namespace mas.Infra
{
    public class Context:DbContext,IUnitOfWork
    {
        private IDbContextTransaction _currentTransaction;
        public IDbContextTransaction GetCurrentTransaction() => _currentTransaction;
        public Context(DbContextOptions<Context> options):base(options)
        {
         
        }
        public DbSet<TradingFeeItem> TradingFeeItems { get; set; }
        public DbSet<TradingCash> TradingCashs { get; set; }
        public DbSet<TradingSecuritiesItem> TradingSecuritiesItems { get; set; }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
           var result = await base.SaveChangesAsync(cancellationToken);
            return true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TradingCashEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TradingFeeItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TradingSecuritiesItemEntityConfiguration());
        }
       
    }
      
}

