using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jello.Data
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime Enddate { get; set; }

        public Dictionary<Guid, Ticket> AssignedTasks { get; set; }

        public Dictionary<Guid, User> AssignedUsers { get; set; }

        public Guid assignedCompany { get; set; }
    }
}
