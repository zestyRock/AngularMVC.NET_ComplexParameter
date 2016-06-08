using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularASPMVC.Models;
using Newtonsoft.Json.Linq;

namespace AngularASPMVC.Controllers
{
    public class HomeController : Controller
    {

        List<Todo> TodoList = new List<Todo>
            {
                new Todo {Content = "Hello It's me", Id = 1, Title = "Adele", Color = "Yellow"},
                new Todo {Content = "Go grocery to get banana", Id = 2, Title = "Shopping", Color = "Yellow"},
                new Todo {Content = "Coffee is ready, let's get it done", Id = 1, Title = "Coding", Color = "Red"}
            };

       

        [HttpGet]
        public ActionResult GetAllTodo()
        {
            return Json(new JsonResult {Data = TodoList}, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult GetFilteredTodo(string filter)
        {
            JObject jObj = JObject.Parse(filter);
            String color = jObj["Color"].ToString();
            String title = jObj["Title"].ToString();
            //filter the result set
            List<Todo> filteredTodo = TodoList.Where(t => t.Color.Equals(color) && t.Title.Equals(title)).ToList();
            return Json(new JsonResult { Data = filteredTodo }, JsonRequestBehavior.AllowGet);
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
    }

}