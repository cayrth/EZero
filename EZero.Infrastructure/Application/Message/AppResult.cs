using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Application.Message
{
    public class AppResult<TEntity> : MessageBox
    {
        public TEntity Data { get; set; }
    }

    public class AppResult : MessageBox
    {
    }
}
