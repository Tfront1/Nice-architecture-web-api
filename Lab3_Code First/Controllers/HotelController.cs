using AutoMapper;
using DataAccess.Models.ClientSpace;
using DataAccess.Models.HotelSpace;
using Lab3_Code_First.Models.Client;
using Lab3_Code_First.Models.Hotel;
using Lab3_Code_First.Services;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// Create new hotel.
        /// </summary>
        /// <param name="hotelDto">Hotel entity to create new hotel entity.</param>
        /// <returns>Hotel that was created.</returns>
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HotelDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        /// <summary>
        /// Delete existing hotel.
        /// </summary>
        /// <param name="hotelDto">Hotel entity to delete existing hotel entity.</param>
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete]
        public async Task<IActionResult> Delete(HotelDto hotelDto)
        {
            var hotel = mapper.Map<Hotel>(hotelDto);
            await service.Delete(hotel);
            return NoContent();
        }

        /// <summary>
        /// Update existing hotel.
        /// </summary>
        /// <param name="hotelDto">Hotel entity to update existing hotel entity.</param>
        /// <returns>Hotel that was updated.</returns>
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HotelDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut]
        public async Task<IActionResult> Update(HotelDto hotelDto)
        {
            var hotel = mapper.Map<Hotel>(hotelDto);
            var updatedHotel = mapper.Map<HotelDto>(await service.Update(hotel));
            return Ok(updatedHotel);
        }

        /// <summary>
        /// Get existing hotel by id.
        /// </summary>
        /// <param name="id">Hotel id to get existing hotel entity.</param>
        /// <returns>Hotel that was finded.</returns>
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HotelDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        /// <summary>
        /// Get all existing hotels.
        /// </summary>
        /// <returns>Hotels that was finded.</returns>
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<HotelDto>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
