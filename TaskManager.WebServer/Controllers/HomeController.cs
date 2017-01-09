using System.Collections.Generic;
using System.Web.Mvc;
using TaskManager.WebServer.Models;
using TaskManager.WebServer.Utilities;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TaskManager.WebServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationServerGateway gateway = new ApplicationServerGateway();
            var tasks = new List<TaskModel>();
            var response = gateway.GetTasks<TaskModel>("http://localhost:63441/api/task");
           
            return View(response);
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