using RabbitMQ.Client;

namespace Core.Rabbitmq.Abstract;

public interface IRabbitMqService
{
    IConnection RabbitMqConneciton(string uri);
}

