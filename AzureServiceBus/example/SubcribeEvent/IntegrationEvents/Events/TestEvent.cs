using EventBus.Events;

namespace PublishEvent.IntegrationEvents.Events
{
    public class TestEvent : IntegrationEvent
    {
        public int OrderId { get; set; }
        public string Message { get; set; }
    }
}