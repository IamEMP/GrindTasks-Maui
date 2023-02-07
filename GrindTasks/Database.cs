using System;
using GrindTasks.ViewModel;
using SQLite;
namespace GrindTasks
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<TaskData>();
        }
        public Task<List<TaskData>> GetTasksAsync()
        {
            return _database.Table<TaskData>().ToListAsync();
        }

        public Task <int> SaveTasksAsync(TaskData taskData)
        {
            return _database.InsertAsync(taskData);
        }
        public Task<int> UpdateTasksAsync(TaskData taskData)
        {
            return _database.UpdateAsync(taskData);
        }
        public Task<int> DeleteTasksAsync(TaskData taskData)
        {
            return _database.DeleteAsync(taskData);
        }
    }
}

