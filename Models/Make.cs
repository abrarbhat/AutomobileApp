using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileManagement.Models
{
    public class Make
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Collection<Model> Models { get; set; }

        public Make()
        {
            Models= new Collection<Model>();
        }
    }
}
