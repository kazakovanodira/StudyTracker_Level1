using StudyTracker_Level1.Database;
using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Repositories;

public class MessageRepository : IMessageRepository
{
    public MessageModel? AddMessage(MessageModel message)
    {
        var messageWithTheSameText = InMemoryDatabase.Messages.FirstOrDefault(m => m.Message == message.Message);
        if (messageWithTheSameText != null)
        {
            // add logging here
            return null;
        }
        
        InMemoryDatabase.Messages.Add(message);

        return InMemoryDatabase.Messages.LastOrDefault();
    }

    public List<MessageModel> GetMessagesByCategory(Category category) =>
        InMemoryDatabase.Messages.Where(m => m.Category == category).ToList();

    public List<MessageModel> GetAllMessages() => 
        InMemoryDatabase.Messages;
    
    public MessageModel? GetLastMessage() =>
        InMemoryDatabase.Messages.LastOrDefault();

    public int GetAllMessagesCount() => 
        InMemoryDatabase.Messages.Count;
    

    public MessageModel? UpdateMessageCategory(Guid msgId, Category newCategory)
    {
        var message = InMemoryDatabase.Messages.FirstOrDefault(m => m.Id == msgId);
        if (message == null)
        {
            return null;
        }
        
        message.Category = newCategory;

        return message;
    }

    public MessageModel? DeleteMessage(Guid msgId)
    {
        var message = InMemoryDatabase.Messages.FirstOrDefault(m => m.Id == msgId);
        if (message == null)
        {
            return null;
        }

        InMemoryDatabase.Messages.RemoveAll(m => m.Id == msgId);

        return message;
    }
}