using EZero.Infrastructure.Domain.Entities;
using EZero.Infrastructure.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Model
{
    public class User : AggregateRoot
    {
        public string Realname { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }
    }
}
