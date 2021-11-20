using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jello.Data
{
    public class Ticket
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Name { get; set; }

        public Int32 Estimate { get; set; }

        public String State { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime Enddate { get; set; }

        public Dictionary<Guid, User> AssignedUsers { get; set; }

        [Required]
        public Guid AssignedProject { get; set; }
    }
}

