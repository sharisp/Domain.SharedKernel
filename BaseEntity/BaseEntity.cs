using Domain.SharedKernel.HelperFunctions;
using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SharedKernel.BaseEntity
{
    public class BaseEntity
    {
        public long Id { get; init; }

        public BaseEntity()
        {

            Id = IdGeneratorFactory.NewId();
        }

        /// <summary>
        /// 领域事件
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
