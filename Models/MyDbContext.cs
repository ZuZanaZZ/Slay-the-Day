using Microsoft.EntityFrameworkCore;

namespace ToDo.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}


