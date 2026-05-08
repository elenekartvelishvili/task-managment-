using Microsoft.EntityFrameworkCore;
using TaskManagementAPI.Data;
using TaskManagementAPI.Interfaces;
using TaskManagementAPI.Models;

namespace TaskManagementAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoTask>> GetAllTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TodoTask?> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<TodoTask> CreateTaskAsync(TodoTask task)
        {
            _context.Tasks.Add(task);

            await _context.SaveChangesAsync();

            return task;
        }

        public async Task<bool> UpdateTaskAsync(int id, TodoTask updatedTask)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
                return false;

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.IsCompleted = updatedTask.IsCompleted;
            task.DueDate = updatedTask.DueDate;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
                return false;

            _context.Tasks.Remove(task);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
