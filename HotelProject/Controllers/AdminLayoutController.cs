using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {

            return PartialView();   
        }

    }
}
