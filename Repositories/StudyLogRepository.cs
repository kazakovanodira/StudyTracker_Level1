using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Repositories;

public class StudyLogRepository : IStudyLogRepository
{
    public Task<ApiResponse<StudyLogModel>> AddStudyLog(StudyLogModel logModel)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<List<StudyLogModel>>> GetStudyLogsByDate(DateTime logDate)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<List<StudyLogModel>>> GetAllStudyLogs()
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<StudyLogModel>> DeleteStudyLog(Guid logId)
    {
        throw new NotImplementedException();
    }
}