using System;
using System.Collections.Generic;

namespace DegreePlan.Models
{
    public class Student
    {
        public int StudenTermID { get; set; }
        public int Term { get; set; }
        public string TermAbv { get; set; }
        public string TermName { get; set; }

        public ICollection<Student> StudentID { get; set; }
    }
}