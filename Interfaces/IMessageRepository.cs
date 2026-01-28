using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Interfaces;

public interface IMessageRepository
{
    MessageModel? AddMessage(MessageModel message);
    // List<MessageModel> GetMessagesByCategory(Category category);
    // List<MessageModel> GetAllMessages();
    public MessageModel? GetLastMessage();
    int GetAllMessagesCount();
    // MessageModel? UpdateMessageCategory(Guid msgId, Category newCategory);
    // MessageModel? DeleteMessage(Guid msgId);
}