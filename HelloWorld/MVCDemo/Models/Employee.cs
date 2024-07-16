﻿using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Key]
        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int Salary {  get; set; }    
        public int Deptid { get; set; }
    }
}
