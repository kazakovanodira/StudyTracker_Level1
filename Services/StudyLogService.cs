using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models;
using StudyTracker_Level1.Models.DTOs;

namespace StudyTracker_Level1.Services;

public class StudyLogService : IStudyLogService
{
    private IStudyLogRepository _studyLogRepository;

    public StudyLogService(IStudyLogRepository studyLogRepository)
    {
        _studyLogRepository = studyLogRepository;
    }
    
    public ApiResponse<StudyLogModel?> AddStudyLog(StudyLogDto slDto)
    {
        int idCount = _studyLogRepository.GetAllStudyLogCount();

        var result = _studyLogRepository.AddStudyLog(new StudyLogModel
        {
            StartTime = slDto.StartTime,
            EndTime = slDto.EndTime,
            InternalId = idCount,
            Id = Guid.NewGuid(),
            Hours = (slDto.EndTime - slDto.StartTime).TotalHours
        });
        
        if (result == null)
        {
            return new ApiResponse<StudyLogModel?>
            {
                ErrorMessage = "Study log with this start time already exists in the database.",
                StatusCode = 400
            };
        }

        return new ApiResponse<StudyLogModel?>
        {
            Result = _studyLogRepository.GetLastStudyLog(),
            StatusCode = 201
        }; 
    }

}