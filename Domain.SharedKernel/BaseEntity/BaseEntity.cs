using Domain.SharedKernel.HelperFunctions;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SharedKernel.BaseEntity
{
    /// <summary>
    /// BaseEntity is the base class for all entities in the domain layer.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Id is the unique identifier for the entity.using IdGen for distributed systems.
        /// </summary>
        public long Id { get; init; }


        private BaseEntity()
        {
        }
        /// <summary>
        /// long? existingId  supports both new entities and existing entities.
        /// </summary>
        /// <param name="existingId"></param>
        public BaseEntity(long? existingId = null)
        {
            Id = existingId ?? IdGeneratorFactory.NewId();
        }

        /// <summary>
        /// domain events
        /// </summary>

        [NotMapped]
        private readonly List<INotification> events = new();
        /// <summary>
        /// add domain event to the entity.
        /// </summary>
        /// <param name="eventItem"></param>
        public void AddDomainEvent(INotification eventItem)
        {
            events.Add(eventItem);
        }
        /// <summary>
        /// add domain event to the entity if it does not already exist.
        /// </summary>
        /// <param name="eventItem"></param>
        public void AddIfNotExists(INotification eventItem)
        {
            if (!events.Contains(eventItem))
            {
                events.Add(eventItem);
            }

        }
        /// <summary>
        /// GetDomainEvents returns the list of domain events for the entity.
        /// </summary>
        /// <returns></returns>
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
