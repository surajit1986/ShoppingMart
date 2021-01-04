namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int id, string message = null, string details= null) : base(id, message)
        {
            Details = details;
        }
        public string Details { get; set; }
    }
}