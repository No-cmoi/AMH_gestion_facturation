using AMH_Gestion.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AMH_Gestion.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Quote> Quotes { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

public DbSet<AMH_Gestion.Models.QuoteDetail> QuoteDetail { get; set; } = default!;
}