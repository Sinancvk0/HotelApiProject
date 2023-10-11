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

        public  PartialViewResult PreoloaderPartial()
        {

            return PartialView();   
        }

        public PartialViewResult NavheaderPartial()
        {

            return PartialView();
        }

    }
}
