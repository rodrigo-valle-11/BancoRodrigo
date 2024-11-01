public class BancoRodrigoContext : DbContext
{
    public BancoRodrigoContext() : base("name=BancoRodrigoContext")
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Loan> Loans { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Loan> Loans { get; set; } // Para préstamos
    public DbSet<Investment> Investments { get; set; } // revisar por si las moscas

}
