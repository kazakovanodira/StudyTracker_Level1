namespace StudyTracker_Level1.Models;

public class StudyLogModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int InternalId { get; set; }
    public Guid Id { get; set; }
    public decimal Hours { get; set; }
}