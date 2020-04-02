using Microsoft.EntityFrameworkCore;

namespace Zoo.Place.Data
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext(DbContextOptions<ZooDbContext> options):base(options){}
        private DbSet<Domain.Zoo> Zoos { get; set; }



    }
}
