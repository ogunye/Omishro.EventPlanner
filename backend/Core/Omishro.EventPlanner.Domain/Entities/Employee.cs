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
    public class Employee : BaseAuditableEntity
    {
        [ForeignKey(nameof(Employee_Address))]
        public Guid Employee_AddressId { get; set; }

        [Required(ErrorMessage ="First Name is a required field.")]
        [StringLength(50, ErrorMessage ="Maximum .character length is 50")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum .character length is 50")]
        public string? LastName { get; set;}

        [Required(ErrorMessage = "Phone Number is a required field.")]
        [StringLength(12, ErrorMessage = "Maximum .character length is 12")]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public virtual Employee_Address? Employee_Address { get; set; }


        public Employee() { }

    }
}
