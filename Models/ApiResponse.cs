namespace StudyTracker_Level1.Models;

public class ApiResponse<T>
{
    public T? Resul { get; set; }
    public int StatusCode { get; set; }
    public string? ErrorMessage { get; set; }
    public bool IsSuccess => String.IsNullOrEmpty(ErrorMessage);
}