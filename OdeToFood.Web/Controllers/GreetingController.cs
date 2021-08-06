using System.Configuration;
using System.Net;
using System.Web.Mvc;
using OdeToFood.Data.Models;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET
        public ActionResult Index(string name)
        {
            // var name = HttpContext.Request.QueryString["name"];
            var model = new GreetingViewModel();
            model.Name = name ?? "No Name";
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}