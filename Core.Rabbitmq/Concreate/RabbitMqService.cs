using Core.Rabbitmq.Abstract;
using RabbitMQ.Client;

namespace Core.Rabbitmq.Concreate;

public class RabbitMqService : IRabbitMqService
{
    public IConnection RabbitMqConneciton(string uri)
    {
        ConnectionFactory factory = new ConnectionFactory
        {
            Uri = new Uri(uri, UriKind.RelativeOrAbsolute)
        };

        if (uri == null || uri == "")
        {
            throw new Exception("");
        }


        return factory.CreateConnection();
    }
}

