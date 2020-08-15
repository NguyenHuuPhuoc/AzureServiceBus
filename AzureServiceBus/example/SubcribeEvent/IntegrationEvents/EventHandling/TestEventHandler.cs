using EventBus.Abstractions;
using PublishEvent.IntegrationEvents.Events;
using System;
using System.Threading.Tasks;

namespace SubcribeEvent.IntegrationEvents.EventHandling
{
    public class TestEventHandler : IIntegrationEventHandler<TestEvent>
    {
        public TestEventHandler()
        {
        }

        public async Task Handle(TestEvent @event)
        {
            await Task.CompletedTask;
            Console.WriteLine(@event);
        }
    }
}