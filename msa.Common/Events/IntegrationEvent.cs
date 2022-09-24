namespace msa.Common.Events
{
    public abstract class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        [System.Text.Json.Serialization.JsonConstructor]
        public IntegrationEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreationDate = createDate;
        }

        [System.Text.Json.Serialization.JsonInclude]
        public Guid Id { get; private init; }

        [System.Text.Json.Serialization.JsonInclude]
        public DateTime CreationDate { get; private init; }
    }
}
