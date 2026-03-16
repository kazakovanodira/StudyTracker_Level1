using Microsoft.AspNetCore.Mvc;
using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models.DTOs;

namespace StudyTracker_Level1.Controllers;

[ApiController]
[Route("api/[controller]")]

public class StudyLogController : ControllerBase
{
    private IStudyLogService _studyLogService;
    private IStudyLogRepository _studyLogRepository;
    
    public StudyLogController(
        IStudyLogService studyLogService, 
        IStudyLogRepository studyLogRepository)
    {
        _studyLogService = studyLogService;
        _studyLogRepository = studyLogRepository;
    }

    [HttpPost]
    public IActionResult AddStudyLog(StudyLogDto slDto)
    {
        if (slDto.EndTime <= slDto.StartTime)
        {
            return BadRequest("Entered start and/or end datetime is invalid.");
        }
        
        var response = _studyLogService.AddStudyLog(slDto);
        if (response.IsSuccess)
        {
            return Ok(response.Result);
        }
        return StatusCode(response.StatusCode, response.ErrorMessage);
    }
}