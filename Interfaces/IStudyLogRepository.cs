using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Interfaces;

public interface IStudyLogRepository
{
    Task<ApiResponse<StudyLogModel>> AddStudyLog(StudyLogModel logModel);
    Task<ApiResponse<List<StudyLogModel>>> GetStudyLogsByDate(DateTime logDate);
    Task<ApiResponse<List<StudyLogModel>>> GetAllStudyLogs();
    Task<ApiResponse<StudyLogModel>> DeleteStudyLog(Guid logId);
}