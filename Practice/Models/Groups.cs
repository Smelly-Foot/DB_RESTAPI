﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Groups
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int id_student { get; set; }
    }
}
