
using SQLite;

namespace GrindTasks
{

    public class TaskData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string todolist { get; set; }
        public string taskDateList { get; set; }

        public string toDoWithDates
        {
            get
            {
                return $"{todolist} {taskDateList}";
            }
        }
    }
}
