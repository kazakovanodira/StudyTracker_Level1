using System.ComponentModel.DataAnnotations;

namespace StudyTracker_Level1.Models;

public class MessageModel
{
    public int Category { get; set; }
    public int InternalId { get; set; }
    public Guid Id { get; set; }
    public string Message { get; set; } = String.Empty; 
}