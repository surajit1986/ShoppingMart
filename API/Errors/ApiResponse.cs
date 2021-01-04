using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int id, string message = null)
        {
            Id = id;
            Message = message?? GetDefaultMessageForStatusCode(id);
        }

        private string GetDefaultMessageForStatusCode(int id)
        {
            return id switch{
                400 => "Not found",
                401 => "Not authorize",
                404 => "Resource not found",
                500 => "Server error",
                _ => "General error"

            };
        }

        public int Id { get; set; }
        public string Message { get; set; }
    }
}