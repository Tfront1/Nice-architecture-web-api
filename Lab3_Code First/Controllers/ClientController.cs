using AutoMapper;
using DataAccess.Models.ClientSpace;
using Lab3_Code_First.Models.Client;
using Lab3_Code_First.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace Lab3_Code_First.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IEntityServiceBase<Guid, Client> service;
        private readonly IMapper mapper;
        public ClientController(IEntityServiceBase<Guid, Client> service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            client.Id = Guid.NewGuid();
            var newClient = mapper.Map<ClientDto>(await service.Create(client));
            return Created(
                nameof(newClient),
                newClient);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            await service.Delete(client);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            var updatedClient = mapper.Map <ClientDto>(await service.Update(client));
            return Ok(updatedClient);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var client = mapper.Map<ClientDto>(await service.GetById(id));
            if (GetById == null)
            {
                return NoContent();
            }

            return Ok(client);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var clients = await service.GetAll();
            List<ClientDto> clientDtos = new List<ClientDto>();
            foreach (Client c in clients) {
                clientDtos.Add(mapper.Map<ClientDto>(c));
            }

            if (clientDtos.Count() == 0)
            {
                return NoContent();
            }

            return Ok(clientDtos);
        }
    }
}
