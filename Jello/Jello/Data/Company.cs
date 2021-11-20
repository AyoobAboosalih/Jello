using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jello.Data
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Name { get; set; }

        public Dictionary<Guid,Project> AssignedProjects { get; set; }

        public Dictionary<Guid, User> AssignedUsers { get; set; }

    }
}
