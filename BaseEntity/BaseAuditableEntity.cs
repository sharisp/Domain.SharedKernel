﻿namespace Domain.SharedKernel.BaseEntity
{
    public abstract class BaseAuditableEntity : BaseEntity
    {

        public DateTimeOffset? CreateDateTime { get; set; }

        public DateTimeOffset? UpdateDateTime { get; set; }

        public DateTimeOffset? DeleteDateTime { get; set; }

        public bool IsDel { get; set; }

        public string? Descriptions { get; set; }

        public long? CreatorUserId { get; set; }

        public long? UpdaterUserId { get; set; }

        public long? DeleterUserId { get; set; }


    }
}
