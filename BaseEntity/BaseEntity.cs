using Domain.SharedKernel.HelperFunctions;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SharedKernel.BaseEntity
{
    public class BaseEntity
    {
        public long Id { get; init; }


        private BaseEntity()
        {
        }
        public BaseEntity(long? existingId = null)
        {
            Id = existingId ?? IdGeneratorFactory.NewId();
        }

        /// <summary>
        /// domain events
        /// </summary>

        [NotMapped]
        private readonly List<INotification> events = new();

        public void AddDomainEvent(INotification eventItem)
        {
            events.Add(eventItem);
        }
        public void AddIfNotExists(INotification eventItem)
        {
            if (!events.Contains(eventItem))
            {
                events.Add(eventItem);
            }

        }
        public List<INotification> GetDomainEvents()
        {
            return events;
        }
        public void ClearDomainEvents()
        {
            events.Clear();
        }
    }
}
