﻿using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using System.Text;

namespace ShoppingCart.MessageBus
{
    public class MessageBus : IMessageBus
    {
        private string connectionString = "AZ SERVICE BUS CONNECTION HERE";
        public async Task PublishMessage(object messageContent, string queueName)
        {
            await using var client = new ServiceBusClient(connectionString);

            ServiceBusSender sender = client.CreateSender(queueName);

            var jsonMessage = JsonConvert.SerializeObject(messageContent);

            ServiceBusMessage serviceBusMessage = new ServiceBusMessage(Encoding.UTF8.GetBytes(jsonMessage))
            {
                CorrelationId = Guid.NewGuid().ToString(),
            };

            await sender.SendMessageAsync(serviceBusMessage);
            await client.DisposeAsync();
        }
    }
}
