using Microsoft.EntityFrameworkCore;

namespace FormODV.Data.Concrete;

public class FormDbContext : DbContext
{
    public FormDbContext(DbContextOptions<FormDbContext> options) : base(options)
    {
    }

    public DbSet<Form> Forms => Set<Form>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Form>().HasData(
            new List<Form>(){
                new Form
            }
        );
    }
}
