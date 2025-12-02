using AutoMapper;
using StudyTracker_Level1.Models;
using StudyTracker_Level1.Models.DTOs;

namespace StudyTracker_Level1;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<MessageModel, MessageDto>();
        CreateMap<StudyLogModel, StudyLogDto>();
    }
}