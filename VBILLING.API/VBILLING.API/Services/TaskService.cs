using Microsoft.EntityFrameworkCore;
using VBILLING.API.Context;
using VBILLING.API.Interfaces;
using VBILLING.API.Models;
using VBILLING.API.Responses;
 

namespace VBILLING.API.Services
{
    public class TaskService : ITaskService
    {
        private readonly DatabaseContext tasksDbContext;

        public TaskService(DatabaseContext tasksDbContext)
        {
            this.tasksDbContext = tasksDbContext;
        }

        public async Task<DeleteTaskResponse> DeleteTask(int taskId, int userId)
        {
            var task = await tasksDbContext.TaskDetails.FindAsync(taskId);

            if (task == null)
            {
                return new DeleteTaskResponse
                {
                    Success = false,
                    Error = "Task not found",
                    ErrorCode = "T01"
                };
            }

            if (task.UserId != userId)
            {
                return new DeleteTaskResponse
                {
                    Success = false,
                    Error = "You don't have access to delete this task",
                    ErrorCode = "T02"
                };
            }

            tasksDbContext.TaskDetails.Remove(task);

            var saveResponse = await tasksDbContext.SaveChangesAsync();

            if (saveResponse >= 0)
            {
                return new DeleteTaskResponse
                {
                    Success = true,
                    TaskId = task.Id
                };
            }

            return new DeleteTaskResponse
            {
                Success = false,
                Error = "Unable to delete task",
                ErrorCode = "T03"
            };
        }

        public async Task<GetTasksResponse> GetTasks(int userId)
        {
            var tasks = await tasksDbContext.TaskDetails.Where(o => o.UserId == userId).ToListAsync();

            if (tasks.Count == 0)
            {
                return new GetTasksResponse
                {
                    Success = false,
                    Error = "No tasks found for this user",
                    ErrorCode = "T04"
                };
            }

            return new GetTasksResponse { Success = true, TaskDetails = tasks };

        }

        public async Task<SaveTaskResponse> SaveTask(TaskDetails task)
        {
            await tasksDbContext.TaskDetails.AddAsync(task);

            var saveResponse = await tasksDbContext.SaveChangesAsync();

            if (saveResponse >= 0)
            {
                return new SaveTaskResponse
                {
                    Success = true,
                    Task = task
                };
            }
            return new SaveTaskResponse
            {
                Success = false,
                Error = "Unable to save task",
                ErrorCode = "T05"
            };
        }
    }
}
