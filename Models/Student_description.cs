using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Student_description
    {
        [Key]
        public int student_id { get; set; }
        public int age { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string adress { get; set; }
        public string country { get; set; }
    }
}
