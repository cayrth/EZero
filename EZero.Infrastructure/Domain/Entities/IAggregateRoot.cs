using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Domain.Entities
{
    /// <summary>
    /// 聚合
    /// </summary>
    public interface IAggregateRoot : IAggregateRoot<int>, IEntity
    {

    }

    public interface IAggregateRoot<TPrimaryKey> : IEntity<TPrimaryKey>
    {
    }
}
