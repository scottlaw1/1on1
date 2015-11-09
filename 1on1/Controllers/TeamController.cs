using _1on1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace _1on1.Controllers
{
    public class TeamController : Controller
    {
        private Team team;

        public TeamController()
        {
            team = new Team();

            var person1 = new Person
            {
                FirstName = "Gunjan",
                LastName = "Sureja",
                EmailAddress = "gsureja@nciinc.com",
                BirthDate = new DateTime(1985, 6, 1),
                Skills = new List<string>() { "Informatica", "Control-M", "Bash", "Perl", "SQL" }
            };

            var person2 = new Person
            {
                FirstName = "Uma",
                LastName = "Shankar",
                EmailAddress = "ushankar@nciinc.com",
                BirthDate = new DateTime(1960, 6, 1),
                Skills = new List<string>() { "Tableau", "SQL" }
            };

            var person3 = new Person
            {
                FirstName = "Mikhail",
                LastName = "Zyuzin",
                EmailAddress = "mzyuzin@nciinc.com",
                BirthDate = new DateTime(1955, 6, 1),
                Skills = new List<string>() { "Informatica", "SQL", "Java" }
            };

            team.TeamMembers.Add(person1);
            team.TeamMembers.Add(person2);
            team.TeamMembers.Add(person3);
        }

        public ActionResult Index()
        {
            return View(team);
        }

        public ActionResult SearchPeople(string searchText)
        {
            var term = searchText.ToLower();
            var result = team.TeamMembers
                .Where(p =>
                    p.FirstName.ToLower().Contains(term) ||
                    p.LastName.ToLower().Contains(term)
                );

            return PartialView("_SearchPeople", result);
        }
    }
}