using StudyTracker_Level1.Enums;
using StudyTracker_Level1.Models;
using StudyTracker_Level1.Models.DTOs;

namespace StudyTracker_Level1.Interfaces;

public interface IMessageService
{
    ApiResponse<MessageModel?> AddMessage(MessageDto messageDto);
    ApiResponse<MessageDto?> GenerateRandomMessageByCategory(Category category);
    // ApiResponse<MessageDto?> UpdateMessageCategory(Guid msgId, Category newCategory);
    // ApiResponse<MessageDto?> DeleteMessage(Guid msgId);
}