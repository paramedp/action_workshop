using Microsoft.EntityFrameworkCore;
using workshop.Model.Entities;

namespace workshop.Model
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
        }

        public DbSet<UserEntity> UserEntitys { get; set; }
    }
}
