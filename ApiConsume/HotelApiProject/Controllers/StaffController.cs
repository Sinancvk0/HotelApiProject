
using Bussines.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
      private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {

            return Ok();
        }
        [HttpPost]
        public IActionResult AddStaff()
        {

            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff()
        {

            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetStaff()
        {

            return Ok();
        }
    }
}
