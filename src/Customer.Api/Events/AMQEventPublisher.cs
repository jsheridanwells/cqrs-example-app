using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver.Core.Events;
using RabbitMQ.Client;

namespace Customer.Api.Events
{
    public class AMQEventPublisher
    {
        private readonly ConnectionFactory _connectionFactory;

        public AMQEventPublisher(IHostingEnvironment env)
        {
           _connectionFactory = new ConnectionFactory();
           var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
               .AddEnvironmentVariables();
           
           builder.Build().GetSection("ampq").Bind(_connectionFactory);
        }

        public void PublishEvent<T>(T @event) where T : IEvent
        {
            using (IConnection conn = _connectionFactory.CreateConnection())
            {
                using (IModel channel = conn.CreateModel())
                {
//                    var queue = @event is CustomerCreatedEvent ? 
                        
                }
            } 
        }
    }
}