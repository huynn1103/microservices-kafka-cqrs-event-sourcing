namespace CQRS.Core.Messages
{
    public abstract class Message
    {
        public Guid id { get; set; }
    }
}