using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JU_Bibliotek1.Controllers
{
    public class AuthorsController : Controller
    {
        // GET: AuthorSearch
        public ActionResult Index()
        {
            return View("Authors");
        }
    }
}