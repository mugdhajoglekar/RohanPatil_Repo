using System.Threading.Tasks;
using AssignmentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentAPI.Context
{
    public class DB_Context : DbContext, Interface_DB_Context
    {
        public DB_Context(DbContextOptions<DB_Context> options):base(options)
        {
        }
        public DbSet<Manager> Managers { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
