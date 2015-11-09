using _1on1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace _1on1.Controllers
{
    public class TeamController : Controller
    {
        private static Team team;

        static TeamController()
        {
            team = new Team();

            var person1 = new Person
            {
                FirstName = "Gunjan",
                LastName = "Sureja",
                EmailAddress = "gsureja@nciinc.com",
                BirthDate = new DateTime(1985, 6, 1),
                Skills = new HashSet<string>() { "Informatica", "Control-M", "Bash", "Perl", "SQL" },
                IsContractor = true
            };

            var person2 = new Person
            {
                FirstName = "Uma",
                LastName = "Shankar",
                EmailAddress = "ushankar@nciinc.com",
                BirthDate = new DateTime(1960, 6, 1),
                Skills = new HashSet<string>() { "Tableau", "SQL" },
                IsContractor = false
            };

            var person3 = new Person
            {
                FirstName = "Mikhail",
                LastName = "Zyuzin",
                EmailAddress = "mzyuzin@nciinc.com",
                BirthDate = new DateTime(1955, 6, 1),
                Skills = new HashSet<string>() { "Informatica", "SQL", "Java" },
                IsContractor = true
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

        public ActionResult AddTeamMember()
        {
            var person = new Person();
            return View(person);
        }

        [HttpPost]
        public ActionResult AddTeamMember(Person person)
        {
            if (ModelState.IsValid)
            {
                team.TeamMembers.Add(person);
                return RedirectToAction("/");
            }

            return View(person);
        }
    }
}