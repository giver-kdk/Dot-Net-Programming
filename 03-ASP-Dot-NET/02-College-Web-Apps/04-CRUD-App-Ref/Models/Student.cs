﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_App.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Name lenght should be within 2 and 60")]
        public string Name { get; set; }
        public string Address{ get; set; }
        public Student() { }
        public Student(int Id, string Name, string Address) {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
        }
    }
}
