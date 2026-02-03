using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models;
using StudyTracker_Level1.Models.DTOs;
using StudyTracker_Level1.Enums;

namespace StudyTracker_Level1.Services;

public class MessageService : IMessageService
{
    private IMessageRepository _messageRepository;

    public MessageService(
        IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public ApiResponse<MessageModel?> AddMessage(MessageDto message)
    {
        int idCount = _messageRepository.GetAllMessagesCount();

        var result = _messageRepository.AddMessage(new MessageModel
        {
            Category = (int)Enum.Parse<Category>(message.Category),
            InternalId = idCount,
            Id = Guid.NewGuid(),
            Message = message.Message
        });

        if (result == null)
        {
            return new ApiResponse<MessageModel?>
            {
                ErrorMessage = "Message with this text already exists.",
                StatusCode = 400
            };
        }

        return new ApiResponse<MessageModel?>
        {
            Result = _messageRepository.GetLastMessage(),
            StatusCode = 201
        };
    }

    public ApiResponse<MessageDto?> GenerateRandomMessageByCategory(Category category)
    {
        var messagesInCategory = _messageRepository.GetMessagesByCategory(category);
        if (messagesInCategory.Count == 0)
        {
            return new ApiResponse<MessageDto?>()
            {
                ErrorMessage = "No messages found in this category.",
                StatusCode = 200
            };
        }
    
        var randomMessageIndex = new Random().Next(messagesInCategory.Count);
        var randomMessageDto = new MessageDto()
        {
            Message = messagesInCategory[randomMessageIndex].Message,
            Category = category.ToString()
        };
    
        return new ApiResponse<MessageDto?>
        {
            Result = randomMessageDto,
            StatusCode = 200
        };
    }
    
    // public ApiResponse<MessageDto?> UpdateMessageCategory(Guid msgId, Category newCategory)
    // {
    //     var updatedMessage = _messageRepository.UpdateMessageCategory(msgId, newCategory);
    //     if (updatedMessage == null)
    //     {
    //         return new ApiResponse<MessageDto?>()
    //         {
    //             ErrorMessage = "Message with that ID is not found.",
    //             StatusCode = 400
    //         };
    //     }
    //
    //     return new ApiResponse<MessageDto?>()
    //     {
    //         Result = new MessageDto()
    //         {
    //             Message = updatedMessage.Message,
    //             Category = updatedMessage.Category
    //         },
    //         StatusCode = 200
    //     };
    }
    
    // public ApiResponse<MessageDto?> DeleteMessage(Guid msgId)
    // {
    //     var messageToDelete = _messageRepository.DeleteMessage(msgId);
    //     if (messageToDelete == null)
    //     {
    //         return new ApiResponse<MessageDto?>()
    //         {
    //             ErrorMessage = "Message with that ID is not found.",
    //             StatusCode = 400
    //         };
    //     }
    //
    //     return new ApiResponse<MessageDto?>()
    //     {
    //         Result = new MessageDto()
    //         {
    //             Message = messageToDelete.Message,
    //             Category = messageToDelete.Category
    //         },
    //         StatusCode = 200
    //     };
    // }
