using EventBus.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PublishEvent.IntegrationEvents.Events;

namespace PublishEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IEventBus _eventBus;

        public HomeController(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        public IActionResult Test()
        {
            var @event = new TestEvent
            {
                OrderId = 100,
                Message = "This is message content"
            };

            _eventBus.Publish(@event);
            return Ok();
        }
    }
}