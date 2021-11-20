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

        public Dictionary<Guid, Project> AssignedProjects { get; set; }

        public Dictionary<Guid, Ticket> AssignedTasks { get; set; }
        
    }
}

