using Omishro.EventPlanner.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omishro.EventPlanner.Domain.Entities
{
    public class RefEvent_Type : BaseAuditableEntity
    {
        public string? EventTypeName { get; set; }
        public string? EventType_Description { get; set; }

        public RefEvent_Type() { }

        public ICollection<EventInfo>? EventInfo { get; set; }


        

    }
}
