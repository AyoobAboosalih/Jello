using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jello.Data
{
    public class User
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        public String ContactNumber { get; set; }

        [EmailAddress][Required]
        public String Email { get; set; }

        [Required]
        public Guid assignedCompany { get; set; }

        public List<Project> AssignedProjects { get; set; }

        public List<Ticket> AssignedTasks { get; set; }
        
    }
}

