using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _1on1.Models
{
    public class Person
    {
        public Person()
        {
            Skills = new HashSet<string>();
            BirthDate = DateTime.Now.AddYears(-30);
        }

        public int PersonId { get; set; }

        [Required]
        public DateTime BirthDate;

        public ICollection<string> Skills { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Title { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [UIHint("BooleanButtonLabel")]
        public bool IsContractor { get; set; }
    }
}