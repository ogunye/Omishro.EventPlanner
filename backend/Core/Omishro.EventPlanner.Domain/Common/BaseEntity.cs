﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omishro.EventPlanner.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }     
    }
}
