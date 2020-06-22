using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kafka.AspNetCore.DependencyInjection
{
    public static class IServiceCollectionExtensionMethods
    {
        public static IServiceCollection AddKafkaProducer(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddKafkaConsumer(this IServiceCollection services)
        {
            return services;
        }
    }
}
