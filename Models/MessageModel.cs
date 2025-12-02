namespace StudyTracker_Level1.Models;

public class MessageModel
{
    public Category Category { get; set; }
    public int InternalId { get; set; }
    public Guid Id { get; set; }
    public string Message { get; set; } = String.Empty; 
}

public enum Category
{
    Little = 0,
    Good = 1,
    Exceptional = 2
}