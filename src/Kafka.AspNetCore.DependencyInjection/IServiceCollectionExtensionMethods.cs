using Confluent.Kafka;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kafka.AspNetCore.DependencyInjection
{
    public static class IServiceCollectionExtensionMethods
    {
        public static IKafkaClientBuilder AddKafkaProducerClient(this IServiceCollection services, string name, Action<ProducerConfig> configureClient)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (configureClient == null)
            {
                throw new ArgumentNullException(nameof(configureClient));
            }

            services.Configure(name, configureClient);

            return AddKafkaProducerClientCore(services, name);
        }

        public static IKafkaClientBuilder AddKafkaConsumerClient(this IServiceCollection services, string name, Action<ConsumerConfig> configureClient)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (configureClient == null)
            {
                throw new ArgumentNullException(nameof(configureClient));
            }

            services.Configure(name, configureClient);

            return AddKafkaConsumerClientCore(services, name);
        }

        private static IKafkaClientBuilder AddKafkaProducerClientCore(this IServiceCollection services, string name)
        {
            return new KafkaClientBuilder();
        }

        private static IKafkaClientBuilder AddKafkaConsumerClientCore(this IServiceCollection services, string name)
        {
            services.AddHostedService<>

            return new KafkaClientBuilder();
        }
    }
}
