using System.Text.Json.Serialization;
using Task = VBILLING.API.Models.Task;

namespace VBILLING.API.Responses
{
    public abstract class BaseResponse
    {
        [JsonIgnore()]
        public bool Success { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorCode { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Error { get; set; }
    }
    public class DeleteTaskResponse : BaseResponse
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int TaskId { get; set; }
    }
    public class GetTasksResponse : BaseResponse
    {
        public List<Task> Tasks { get; set; }
    }
    public class LogoutResponse : BaseResponse
    {

    }
    public class SaveTaskResponse : BaseResponse
    {
        public Task Task { get; set; }
    }

    public class SignupResponse : BaseResponse
    {
        public string Email { get; set; }
    }

    public class TaskResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Ts { get; set; }
    }
    public class TokenResponse : BaseResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

    }

    public class ValidateRefreshTokenResponse : BaseResponse
    {
        public int UserId { get; set; }

    }
}
