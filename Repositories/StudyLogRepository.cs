using StudyTracker_Level1.Database;
using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Repositories;

public class StudyLogRepository : IStudyLogRepository
{
    public StudyLogModel? AddStudyLog(StudyLogModel logModel)
    {
        var slWithTheSameStartTime = InMemoryDatabase.Logs.FirstOrDefault(sl => sl.StartTime == logModel.StartTime);
        if (slWithTheSameStartTime != null)
        {
            // add logging here
            return null;
        }
        
        InMemoryDatabase.Logs.Add(logModel);

        return InMemoryDatabase.Logs.LastOrDefault();
    }

    public void AddStudyLogsInBulk(List<StudyLogModel> bulkSLs)
    {
        throw new NotImplementedException();
    }

    public List<StudyLogModel> GetStudyLogsByDate(DateTime logDate)
    {
        throw new NotImplementedException();
    }

    public List<StudyLogModel> GetAllStudyLogs()
    {
        throw new NotImplementedException();
    }

    public int GetAllStudyLogCount() => 
        InMemoryDatabase.Logs.Count;

    public StudyLogModel? GetLastStudyLog() => 
        InMemoryDatabase.Logs.LastOrDefault();
    

    public StudyLogModel DeleteStudyLog(Guid logId)
    {
        throw new NotImplementedException();
    }
}