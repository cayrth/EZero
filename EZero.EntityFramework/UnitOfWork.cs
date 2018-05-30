using EZero.Infrastructure.Domain.Uow;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EZero.EntityFrameworkCore
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private AppDbContext _dataContext;

        public UnitOfWork(AppDbContext dataContext)
        {
            _dataContext = dataContext;
        }
        

        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return _dataContext.SaveChanges();
        }

        public void Rollback()
        {

        }

        /// <summary>
        /// 异步提交
        /// </summary>
        /// <returns></returns>
        public Task CommitAsync()
        {
            return _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
