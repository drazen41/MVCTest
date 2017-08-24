using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.Models;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        List<People> peopleList = null;
        public HomeController()
        {
            peopleList = new List<People>();
            People person1 = new People() { Name = "Test", Location = "Test" };
            People person2 = new People() { Name = "Test1", Location = "Test1" };
            People person3 = new People() { Name = "Test2", Location = "Test2" };
            peopleList.Add(person1);
            peopleList.Add(person2);
            peopleList.Add(person3);
            System.Web.HttpContext.Current.Session["people"] = peopleList;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PeopleJ()
        {
            return View("PeopleJquery");
        }
        public ActionResult PeopleAngular()
        {
            return View("PeopleAngular");
        }
        public IEnumerable<People> GetAllPeople()
        {
            IEnumerable<People> lista = System.Web.HttpContext.Current.Session["people"] as IEnumerable<People>;
            return lista ;
        }
    }
}