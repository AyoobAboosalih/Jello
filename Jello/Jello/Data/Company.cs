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
        [StringLength(35)]
        public String Name { get; set; }

        public List<Project> AssignedProjects { get; set; }

        public List<User> AssignedUsers { get; set; }

    }
}
