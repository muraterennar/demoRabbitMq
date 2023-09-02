using Core.Rabbitmq.Abstract;
using Core.Rabbitmq.Concreate;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Rabbitmq;

public static class RabbitMqServiceRegistration
{
    public static void AddRabbitMqService(this IServiceCollection services)
    {
        services.AddScoped<IRabbitMqService, RabbitMqService>();
    }
}

