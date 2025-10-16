namespace StudyTracker_Level1.Models;

public class MessageModel
{
    public Category Category { get; set; }
    public int Id { get; set; }
    public string Message { get; set; } = String.Empty; 
}

public enum Category
{
    Little,
    Good,
    Exceptional
}