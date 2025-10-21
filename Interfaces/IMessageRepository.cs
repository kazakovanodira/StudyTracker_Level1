using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Interfaces;

public interface IMessageRepository
{
    Task<ApiResponse<MessageModel>> AddMessage(MessageModel message);
    Task<ApiResponse<MessageModel>> GetMessageByCategory(Category category);
    Task<ApiResponse<List<MessageModel>>> GetAllMessages();
    Task<ApiResponse<MessageModel>> UpdateMessageCategory(int msgId, Category newCategory);
    Task<ApiResponse<MessageModel>> DeleteMessage(int msgId);
}