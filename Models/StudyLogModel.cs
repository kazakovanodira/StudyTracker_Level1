namespace StudyTracker_Level1.Models;

public class StudyLogModel
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int InternalId { get; set; }
    public Guid Id { get; set; }
    public double Hours { get; set; }
}