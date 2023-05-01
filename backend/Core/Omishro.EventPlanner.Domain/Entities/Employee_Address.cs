using Omishro.EventPlanner.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omishro.EventPlanner.Domain.Entities
{
    public class Employee_Address : BaseAuditableEntity
    {
        [Required(ErrorMessage = "House is a required field.")]
        [StringLength(4, ErrorMessage = "Maximum .character length is 4")]
        public string? House_Number { get; set; }

        [Required(ErrorMessage = "Street Name is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum .character length is 50")]
        public string? Street_Name { get; set; }

        [Required(ErrorMessage = "Area Locality is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum .character length is 50")]
        public string? Area_Locality { get; set; }

        [Required(ErrorMessage = "City is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum .character length is 50")]
        public string? City { get; set; }

        [StringLength(50, ErrorMessage = "Maximum .character length is 50")]
        public string? State { get; set; }

        [StringLength(50, ErrorMessage = "Maximum .character length is 50")]
        public string? Country { get; set; }

        public virtual ICollection<Employee>? Employee { get; set; }

        public Employee_Address() { }
        
    }
}
