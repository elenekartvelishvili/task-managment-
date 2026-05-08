using TaskManagementAPI.Models;

namespace TaskManagementAPI.Interfaces
{
    public interface ITaskService
    {
        Task<List<TodoTask>> GetAllTasksAsync();

        Task<TodoTask?> GetTaskByIdAsync(int id);

        Task<TodoTask> CreateTaskAsync(TodoTask task);

        Task<bool> UpdateTaskAsync(int id, TodoTask updatedTask);

        Task<bool> DeleteTaskAsync(int id);
    }
}
