﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public int grade { get; set; }
    }
}
