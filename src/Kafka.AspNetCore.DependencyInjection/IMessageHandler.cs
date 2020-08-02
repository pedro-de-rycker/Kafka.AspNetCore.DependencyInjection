using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.AspNetCore.DependencyInjection
{
    public interface IMessageHandler
    {
        Task HandleAsync(object sender, ConsumeEventArgs args);
    }

    public class ConsumeEventArgs
    {
        public ConsumeResult<Ignore, string> Result { get; set; }

        public DateTime ReceivedAt { get; set; } = DateTime.Now;
    }
}
