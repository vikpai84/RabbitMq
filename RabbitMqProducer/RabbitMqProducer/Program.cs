using System;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace RabbitMqProducer
{
    /*
        Main Protocol used by RabbitMq: AMQP
        run below in command prompt
        docker run -d --hostname my-rabbit --name ecomm-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management
        5672: post used by rabbit mq
        you can use docker logs -f d06 (first 3 digits of the image)
        running admin will be on localhost:15672
     */
    static class Program
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
           
            //QueueProducer.Publish(channel);
            //DirectExchangePublisher.Publish(channel);

            TopicExchangePublisher.Publish(channel);

            //HeaderExchangePublisher.Publish(channel);
        }
    }
}
