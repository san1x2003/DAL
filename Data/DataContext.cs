namespace Sanshop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Shop1; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Sklad> Sklad { get; set; }
        public DbSet<Tovar> Tovar { get; set; }
        public DbSet<Zakaz> Zakaz { get; set; }
    }
}


