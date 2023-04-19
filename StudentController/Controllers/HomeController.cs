using Microsoft.AspNetCore.Mvc;

namespace StudentController.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index(int id)
        {
            ViewData["id"] = id;
            return View();
        }

        public ViewResult About(int id)
        {
            ViewData["id"] = id;
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}
