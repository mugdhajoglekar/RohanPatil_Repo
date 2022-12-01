using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AssignmentAPI.Models;

namespace AssignmentAPI.Context
{
    public interface Interface_DB_Context
    {
        DbSet<Manager> Managers { get; set; }

        Task<int> SaveChanges();
    }
}
