using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        
        public string FullName { get; set; }
        
        [DataType(DataType.Text)]
        public DateTime Birthday { get; set; }
        
        public ICollection<Group> Groups { get; set; }
        
        public ICollection<Project> InProjects { get; set; }
        
        public ICollection<Project> UserProjects { get; set; }
        
        public ICollection<ProjectTask> Tasks { get; set; }
        
    }
}
