
using VBILLING.API.Models;
using VBILLING.API.Responses;
 

namespace VBILLING.API.Interfaces
{
    public interface ITaskService
    {
        Task<GetTasksResponse> GetTasks(int userId);
        Task<SaveTaskResponse> SaveTask(TaskDetails task);
        Task<DeleteTaskResponse> DeleteTask(int taskId, int userId);
    }
}
