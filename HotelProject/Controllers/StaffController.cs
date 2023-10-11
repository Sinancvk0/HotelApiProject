using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
