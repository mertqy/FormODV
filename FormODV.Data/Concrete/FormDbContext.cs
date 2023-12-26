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
                new (){Id = 1,Name = "Form_1,"},
                new (){Id = 2,Name = "Form_2,"},
                new (){Id = 3,Name = "Form_3,"},
                new (){Id = 4,Name = "Form_4,"},
                new (){Id = 5,Name = "Form_5,"},
                new (){Id = 6,Name = "Form_6,"},
                new (){Id = 7,Name = "Form_7,"},
                new (){Id = 8,Name = "Form_8,"},
                new (){Id = 9,Name = "Form_9,"},
                new (){Id = 10,Name = "Form_10,"},
            }
        );
    }
}
