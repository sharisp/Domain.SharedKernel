using Domain.SharedKernel.Interfaces;

namespace Domain.SharedKernel.BaseEntity
{
    public abstract class BaseAuditableEntity : BaseEntity,ICreatorUserId, ISoftDelete
    {

        public DateTimeOffset? CreateDateTime { get; set; }

        public DateTimeOffset? UpdateDateTime { get; set; }

        public DateTimeOffset? DeleteDateTime { get; set; }

        public bool IsDel { get; set; }

        public string? Description { get; set; }

        public long? CreatorUserId { get; set; }

        public long? UpdaterUserId { get; set; }

        public long? DeleterUserId { get; set; }


        public void SoftDelete(ICurrentUser currentUser)
        {
            this.IsDel = true;
            this.DeleteDateTime = DateTimeOffset.Now;
            this.DeleterUserId = currentUser?.UserId;
        }

    }
}
