using System.ComponentModel.DataAnnotations;

namespace StudyTracker_Level1.Models.DTOs;

public class StudyLogDto
{
    [Required]
    public DateTime StartTime { get; set; }
    [Required]
    public DateTime EndTime { get; set; }
}