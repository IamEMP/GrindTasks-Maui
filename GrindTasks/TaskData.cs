
using SQLite;

namespace GrindTasks
{

    public class TaskData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string todolist { get; set; }
    }

}
