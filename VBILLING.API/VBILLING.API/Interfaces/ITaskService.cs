
using VBILLING.API.Models;
using VBILLING.API.Responses;
using Task = VBILLING.API.Models.Task;

namespace VBILLING.API.Interfaces
{
    public interface ITaskService
    {
        Task<GetTasksResponse> GetTasks(int userId);
        Task<SaveTaskResponse> SaveTask(Task task);
        Task<DeleteTaskResponse> DeleteTask(int taskId, int userId);
    }
}
