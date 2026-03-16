using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Interfaces;

public interface IStudyLogRepository
{
    StudyLogModel? AddStudyLog(StudyLogModel logModel);
    void AddStudyLogsInBulk(List<StudyLogModel> bulkSLs);
    List<StudyLogModel> GetStudyLogsByDate(DateTime logDate);
    List<StudyLogModel> GetAllStudyLogs();
    int GetAllStudyLogCount();
    StudyLogModel? GetLastStudyLog();
    StudyLogModel DeleteStudyLog(Guid logId);
}