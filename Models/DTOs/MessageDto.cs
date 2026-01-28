using System.ComponentModel.DataAnnotations;

namespace StudyTracker_Level1.Models.DTOs;

public class MessageDto
{
    [Required]
    public string Category { get; set; }
    [Required]
    public string Message { get; set; }
}