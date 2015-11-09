using _1on1.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _1on1.Controllers
{
    public class TeamMemberController : Controller
    {
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Gunjan",
                LastName = "Sureja",
                EmailAddress = "gsureja@nciinc.com",
                BirthDate = new DateTime(1985, 6, 1),
                Skills = new List<string>() { "Informatica", "Control-M", "Bash", "Perl", "SQL" }
            };

            return View(person);
        }
    }
}