using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Practical4.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group

        public ActionResult ListGroup()
        {
            List<Models.GroupModel> group = new List<Models.GroupModel>();

            group.Add(new Models.GroupModel { StudentNum = "u23684722", FirstName = "Vishal", LastName = "Bhagwan", Email = "u23684722@tuks.co.za", myLink = "/HTML/Person1.html" });
            group.Add(new Models.GroupModel { StudentNum = "u23585600", FirstName = "Callum", LastName = "Molver", Email = "u23585600@tuks.co.za", myLink = "/HTML/Person2.html" });
            group.Add(new Models.GroupModel { StudentNum = "u23582032", FirstName = "Pranavan", LastName = "Naidoo", Email = "u23582032@tuks.co.za", myLink = "/HTML/Person3.html" });
            group.Add(new Models.GroupModel { StudentNum = "u23430273", FirstName = "Maya", LastName = "Pillay", Email = "u23430273@tuks.co.za", myLink = "/HTML/Person4.html" });
            group.Add(new Models.GroupModel { StudentNum = "u23958301", FirstName = "Mahilan", LastName = "Naicker", Email = "u23958301@tuks.co.za", myLink = "/HTML/Person5.html" });

            return View(group);
        }
    }
}