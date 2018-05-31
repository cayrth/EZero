using EZero.Infrastructure.Runtime.Session;

namespace EZero.Infrastructure.Services
{
    public abstract class ApplicationService
    {

        ///// <summary>
        ///// 工作单元
        ///// </summary>
        //public readonly IUnitOfWork UnitOfWork;

        /// <summary>
        /// Session
        /// </summary>
        public ISession Session { get; set; }

    }
}
