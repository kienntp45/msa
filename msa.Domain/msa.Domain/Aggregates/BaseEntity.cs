namespace msa.Domain.Aggregates
{
    public class BaseEntity
    {
        public int Id { get; set; }
        private List<INotification> _domainEvents;
        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }
        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

    }
}
