using StudyTracker_Level1.Models;
using StudyTracker_Level1.Models.DTOs;

namespace StudyTracker_Level1.Interfaces;

public interface IStudyLogService
{
    ApiResponse<StudyLogModel?> AddStudyLog(StudyLogDto slDto);
}