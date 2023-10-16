using AutoMapper;
using Bussines.Abstract;
using DTO.Dtos.RoomDto;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly  IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();

            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();

            }
            var values = _mapper.Map<Room>(roomAddDto);
           _roomService.TInsert(values);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDto roomUpdateDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values=_mapper.Map<Room>(roomUpdateDto);
            _roomService.TUpdate(values);
            return Ok();
        }
    }

}
