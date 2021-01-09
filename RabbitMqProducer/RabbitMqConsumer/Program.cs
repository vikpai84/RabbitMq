using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMqConsumer
{
    /*
        Main Protocol used by RabbitMq: AMQP
        run below in command prompt
        docker run -d --hostname my-rabbit --name ecomm-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management
        5672: post used by rabbit mq
        you can use docker logs -f d06 (first 3 digits of the image)
        running admin will be on localhost:15672
    */
    public static class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            //Create connection
            using var connection = factory.CreateConnection();
            //Create Channel
            using var channel = connection.CreateModel();
            
            //QueueConsumer.Consume(channel);

            //DirectExchangeConsumer.Consume(channel);

            TopicExchangeConsumer.Consume(channel);

            //HeaderExchangeConsumer.Consume(channel);

            //FanoutExchangeConsumer.Consume(channel);
        }
    }
}
