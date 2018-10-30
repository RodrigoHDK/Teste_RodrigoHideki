using System.Data.Entity;

namespace Biblioteca.Models
{
    public class LivrosDbContext : DbContext
    {
        public LivrosDbContext() : base("Biblioteca")
        {
            Database.SetInitializer<LivrosDbContext>
                (new DropCreateDatabaseIfModelChanges<LivrosDbContext>());
        }

        public DbSet<Livros> Livros { get; set; }

    }
    
}