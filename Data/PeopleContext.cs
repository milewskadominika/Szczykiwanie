using Microsoft.EntityFrameworkCore;
using Szczykiwanie.Models;

namespace Szczykiwanie.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; }
    }

}
