namespace ShoppingCart.MessageBus
{
    public interface IMessageBus
    {
        public Task PublishMessage(object messageContent, string queueName);
    }
}
