using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebAPI_2022.Services;
using WebAPI_2022.Models;

namespace WebAPI_2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        //TicketService service;
        [HttpGet]
        [Route("all")]
        public List<Ticket> Get()
        {
            return TicketService.GetAll(); 
        }
        [HttpGet]
        [Route("{id}")]
        public Ticket Get(int id)
        {
            Ticket t = TicketService.Get(id);
            return t;
        }
    }
}
    
