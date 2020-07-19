using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Students
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string second_name { get; set; }
        public int id_group { get; set; }
    }
}
