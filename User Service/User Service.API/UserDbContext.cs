using Microsoft.EntityFrameworkCore;
using User_Service.Controllers;

namespace User_Service
{
    public class UserDbContext : DbContext
    {
        
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}