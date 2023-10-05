using Bussines.Abstract;
using DataAccess.Abstract;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values=_subscribeService.TGetList();
            return Ok(values);
         }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe sub)
        {
            _subscribeService.TInsert(sub);

            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var value=_subscribeService.TGetById(id);

            _subscribeService.TDelete(value);   

            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe sub)
        {
            _subscribeService.TUpdate(sub);

            return Ok();
        }
        [HttpGet]
        public IActionResult GetSubscribe(int id)
        {
            var value= _subscribeService.TGetById(id);
            return Ok(value);

        }
    }
}
