namespace ToDo.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public bool Done { get; set; }
        public required string task { get; set; }

        public ToDoTask()
        {
                    
        }
    }
}
