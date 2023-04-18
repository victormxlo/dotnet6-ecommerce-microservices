namespace GeekShopping.MessageBus
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMessage baseMessage, string queueName);
    }
}