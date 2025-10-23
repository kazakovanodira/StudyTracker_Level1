using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Interfaces;

public interface IMessageRepository
{
    ApiResponse<MessageModel> AddMessage(MessageModel message);
    ApiResponse<List<MessageModel>> GetMessagesByCategory(Category category);
    ApiResponse<List<MessageModel>> GetAllMessages();
    ApiResponse<MessageModel> UpdateMessageCategory(int msgId, Category newCategory);
    ApiResponse<MessageModel> DeleteMessage(int msgId);
}