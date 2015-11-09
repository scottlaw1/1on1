using System;
using System.Collections.Generic;

namespace _1on1.Models
{
    public class Team
    {
        public Team()
        {
            TeamMembers = new List<Person>();
        }

        public IList<Person> TeamMembers { get; set; }

        public void AddMember(Person person)
        {
            throw new NotImplementedException("Not ready for this yet.");
        }

        public void ArchiveMember(Person person)
        {
            throw new NotImplementedException("Not ready for this yet.");
        }
    }
}