using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Application.Abstractions.Services.Concrete;
using Eventify_Tutorial_Series.Application.DTOs;
using Eventify_Tutorial_Series.Application.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace Eventify_Tutorial_Series.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController:ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly ExportService _exportService;
        private readonly ITextService _textService;
        private readonly IFileService _fileService;

        public EventsController(IEventService eventService, ITextService textService, IFileService fileService)
        {
            _eventService = eventService;
            _textService = textService;
            _fileService = fileService;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetEvents([FromQuery]Pagination pagination)
        {
            var events = await _eventService.GetAllEventAsync(pagination);
            return Ok(events);
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventDTO createEventDTO)
        {
            await _eventService.CreateEventAsync(createEventDTO);
            return Ok("Event created successfully");
        }
        
        [HttpPost("[Action]")]
        public async Task<IActionResult> ExportEvents([FromQuery]Pagination pagination, string path)
        {
            var events = await _eventService.GetAllEventAsync(pagination);
            var text = _exportService.ExportEventsAsync(events,path);
            
            return Ok("Event Exported successfully");
        }
    }    
}
