using Omishro.EventPlanner.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omishro.EventPlanner.Domain.Entities
{
    public class EventInfo : BaseAuditableEntity
    {
        [ForeignKey(nameof(RefEvent_Type))]
        public Guid EventTypeId { get; set; }

        [Required(ErrorMessage ="Event Duration is a required field.")]
        [Range(1,100)]
        public int EventDuration { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Start Date is a required field.")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "End Date is a required field.")]
        public DateTime EndDate { get; set; }

        [MaxLength(10, ErrorMessage = "maximum ,character length is 10.")]
        public string? Event_Status { get; set; }

        public RefEvent_Type? Event_Type { get; set; }

        public EventInfo() { }
    }
}
