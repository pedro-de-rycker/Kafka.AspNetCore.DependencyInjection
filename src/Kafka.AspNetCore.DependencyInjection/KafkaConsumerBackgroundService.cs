using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kafka.AspNetCore.DependencyInjection
{
    internal class KafkaConsumerBackgroundService<T> : BackgroundService where T : IMessageHandler
    {
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(stoppingToken.IsCancellationRequested)
            {

            }
        }
    }
}
