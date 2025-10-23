using StudyTracker_Level1.Database;
using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models;

namespace StudyTracker_Level1.Repositories;

public class MessageRepository : IMessageRepository
{
    public ApiResponse<MessageModel> AddMessage(MessageModel message)
    {
        var messageWithTheSameText = InMemoryDatabase.Messages.FirstOrDefault(m => m.Message == message.Message);
        if (messageWithTheSameText != null)
        {
            return new ApiResponse<MessageModel>
            {
                ErrorMessage = "This message already exists in database.",
                StatusCode = 409
            };
        }
        
        InMemoryDatabase.Messages.Add(message);
        
        return new ApiResponse<MessageModel>
        {
            Result = InMemoryDatabase.Messages.LastOrDefault(),
            StatusCode = 201
        };
    }

    public ApiResponse<List<MessageModel>> GetMessagesByCategory(Category category)
    {
        return new ApiResponse<List<MessageModel>>
        {
            Result = InMemoryDatabase.Messages.Where(m => m.Category == category).ToList(),
            StatusCode = 200
        };
    }

    public ApiResponse<List<MessageModel>> GetAllMessages()
    {
        return new ApiResponse<List<MessageModel>>
        {
            Result = InMemoryDatabase.Messages,
            StatusCode = 200
        };
    }

    public ApiResponse<MessageModel> UpdateMessageCategory(int msgId, Category newCategory)
    {
        var message = InMemoryDatabase.Messages.FirstOrDefault(m => m.Id == msgId);
        if (message == null)
        {
            return new ApiResponse<MessageModel>
            {
                ErrorMessage = $"Message with ID {msgId} not found.",
                StatusCode = 404
            };
        }
        
        message.Category = newCategory;
        
        return new ApiResponse<MessageModel>
        {
            Result = message,
            StatusCode = 200
        };
    }

    public ApiResponse<MessageModel> DeleteMessage(int msgId)
    {
        var message = InMemoryDatabase.Messages.FirstOrDefault(m => m.Id == msgId);
        if (message == null)
        {
            return new ApiResponse<MessageModel>
            {
                ErrorMessage = $"Message with ID {msgId} not found.",
                StatusCode = 404
            };
        }

        InMemoryDatabase.Messages.RemoveAll(m => m.Id == msgId);
        
        return new ApiResponse<MessageModel>
        {
            Result = message,
            StatusCode = 200
        };
    }
}