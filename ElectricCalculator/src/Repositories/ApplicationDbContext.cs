using Microsoft.EntityFrameworkCore;
using Repositories.Models;

namespace Repositories;

public class ApplicationDbContext : DbContext
{
    public DbSet<Pricing> Pricings { get; set; }
    public DbSet<CalculationHistory> CalculationHistories { get; set; }

    protected ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("");
        }
    }
}