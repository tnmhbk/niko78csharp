using System.Data.Entity;

namespace EFComposite.Model
{
    public class ExampleContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }
    }
}
