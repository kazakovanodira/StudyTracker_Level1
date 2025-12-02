using Microsoft.AspNetCore.Mvc;
using StudyTracker_Level1.Interfaces;
using StudyTracker_Level1.Models;
using StudyTracker_Level1.Models.DTOs;

namespace StudyTracker_Level1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController : ControllerBase

{
    private IMessageRepository _messageRepository;
    private IMessageService _messageService;

    public MessageController(
        IMessageRepository messageRepository, 
        IMessageService messageService)
    {
        _messageRepository = messageRepository;
        _messageService = messageService;
    }

    [HttpPost]
    public IActionResult AddNewMessage(MessageDto messageDto)
    {
        var response = _messageService.AddMessage(messageDto);
        if (response.IsSuccess)
        {
            return Ok(response.Result);
        }

        return StatusCode(response.StatusCode, response.ErrorMessage);
    }
    
    [HttpGet("random/{category}")]
    public IActionResult GetMessage(Category category)
    {
        var response = _messageService.GenerateRandomMessageByCategory(category);
        if (response.IsSuccess)
        {
            return Ok(response.Result);
        }

        return StatusCode(response.StatusCode, response.ErrorMessage);
    }
    
    [HttpGet("all")]
    public IActionResult GetAllMessages()
    {
        var response = _messageRepository.GetAllMessages();

        return Ok(response);
    }
    
    [HttpPost("{messageId:guid}/update")]
    public IActionResult UpdateMessageCategory(Guid messageId, Category newCategory)
    {
        var response = _messageService.UpdateMessageCategory(messageId, newCategory);
        if (response.IsSuccess)
        {
            return Ok(response.Result);
        }

        return StatusCode(response.StatusCode, response.ErrorMessage);
    }
    
    [HttpDelete("{messageId:guid}/delete")]
    public IActionResult DeleteMessage(Guid messageId)
    {
        var response = _messageService.DeleteMessage(messageId);
        if (response.IsSuccess)
        {
            return Ok(response.Result);
        }

        return StatusCode(response.StatusCode, response.ErrorMessage);
    }
}