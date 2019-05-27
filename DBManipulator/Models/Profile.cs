using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBManipulator.Models
{
    public class Profile
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public DateTime DateOfAnket { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string Hobbies { get; set; }

        public string Gender { get; set; }
    }
}