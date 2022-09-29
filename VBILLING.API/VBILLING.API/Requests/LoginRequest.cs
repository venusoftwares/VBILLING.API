using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VBILLING.API.Requests
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

   

    public class SignupRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime Ts { get; set; }

    }

    public class TaskRequest
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Ts { get; set; }
    }

    public abstract class BaseResponse
    {
        [JsonIgnore()]
        public bool Success { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorCode { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Error { get; set; }
    }
}
