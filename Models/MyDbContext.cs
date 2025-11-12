using Microsoft.EntityFrameworkCore;

namespace ToDo.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }

    public class ToDoTask
    {
        public int Id { get; set; }
        public bool Done { get; set; }
        public required string task { get; set; }
    }
}


