using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homework1.Models
{
    public class Student
    {
        public Student()
        {
            CreationDate = DateTime.Now;
        }


        [DisplayName("Student ID")]
        [Required]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Date of Birth")]
        public DateTime BirthDate { get; set; }

        public string Department { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdateDate { get; set; }



    }
}
