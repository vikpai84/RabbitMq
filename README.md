# RabbitMq
Set up rabbit Mq in local using docker. 

RabbitMq: Message broker --- think about a PostOffice...
Message Broker --- good to decouple microservices.
Producer : Sends Message
Subscriber: Consumers the message
Queue


Main Protocol used by RabbitMq: AMQP
run below in command prompt
docker run -d --hostname my-rabbit --name ecomm-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management

5672: post used by rabbit mq

you can use docker logs -f d06 (first 3 digits of the image)

running admin will be on localhost:15672


Exhange : Something like stock exchange
Routes messages from Publisher to Consumers.

Direct Exchange : uses routing key to pass between Consumer and Publisher

Topic Exchange: Type of Direct key -- does route key pattern match. DOES NOT DO exact match.


Header : routes messages based on header values.

Fanout : routes messages to all the queses bound to it.
