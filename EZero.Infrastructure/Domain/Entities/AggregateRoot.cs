using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Domain.Entities
{
    public abstract class AggregateRoot : AggregateRoot<int>, IAggregateRoot
    {

    }

    public abstract class AggregateRoot<TPrimaryKey> : Entity<TPrimaryKey>, IAggregateRoot<TPrimaryKey>
    {
        /// <summary>
        /// Last modification date of this entity.
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreatedTime { get; set; }
    }
}
