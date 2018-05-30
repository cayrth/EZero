using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EZero.Infrastructure.Domain.Uow
{
    public interface IUnitOfWork
    {
        int Commit();

        /// <summary>
        /// 异步提交
        /// </summary>
        /// <returns></returns>
        Task CommitAsync();

        void Rollback();
    }
}
