using System;
using System.Collections.Generic;

namespace _1on1.Models
{
    public class Person
    {
        public DateTime BirthDate;
        public List<string> Skills;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string EmailAddress { get; set; }
    }
}