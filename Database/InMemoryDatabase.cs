using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Database;

public static class InMemoryDatabase
{
    public static List<MessageModel> Messages = new List<MessageModel>();
    public static List<StudyLogModel> Logs = new List<StudyLogModel>();
}