using System.Collections.Generic;
using System.Web.Mvc;
using TaskManager.WebServer.Models;
using TaskManager.WebServer.Utilities;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TaskManager.Cache;
using System;

namespace TaskManager.WebServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationServerGateway gateway = new ApplicationServerGateway();            
            
            var cache = CacheFactory.CacheManager(Enums.Task.ToString());
            //var tasks = (IList<TaskModel>)(new TaskCache().Get("task"));
            var tasks = (IList<TaskModel>)(cache.Get("task"));
            if (tasks == null)
            {
                tasks = gateway.GetTasks<TaskModel>("http://localhost:63441/api/task");
                cache.Add("task", tasks);
            }
                       
            return View(tasks);
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