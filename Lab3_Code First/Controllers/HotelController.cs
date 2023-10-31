using AutoMapper;
using DataAccess.Models.ClientSpace;
using DataAccess.Models.HotelSpace;
using Lab3_Code_First.Models.Client;
using Lab3_Code_First.Models.Hotel;
using Lab3_Code_First.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_Code_First.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IEntityServiceBase<Guid, Hotel> service;
        private readonly IMapper mapper;
        public HotelController(IEntityServiceBase<Guid, Hotel> service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]
        public async Task<IActionResult> Create(HotelDto hotelDto)
        {
            var hotel = mapper.Map<Hotel>(hotelDto);
            hotel.Id = Guid.NewGuid();
            var newHotel = mapper.Map<HotelDto>(await service.Create(hotel));
            return Created(
                nameof(newHotel),
                newHotel);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(HotelDto hotelDto)
        {
            var hotel = mapper.Map<Hotel>(hotelDto);
            await service.Delete(hotel);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(HotelDto hotelDto)
        {
            var hotel = mapper.Map<Hotel>(hotelDto);
            var updatedHotel = mapper.Map<HotelDto>(await service.Update(hotel));
            return Ok(updatedHotel);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var hotel = mapper.Map<HotelDto>(await service.GetById(id));
            if (GetById == null)
            {
                return NoContent();
            }

            return Ok(hotel);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var hotels = await service.GetAll();
            List<HotelDto> hotelDtos = new List<HotelDto>();
            foreach (Hotel h in hotels)
            {
                hotelDtos.Add(mapper.Map<HotelDto>(h));
            }

            if (hotelDtos.Count() == 0)
            {
                return NoContent();
            }

            return Ok(hotelDtos);
        }
    }
}
