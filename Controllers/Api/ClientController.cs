using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using jmdbase.Data;
using jmdbase.Models;
using jmdbase.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace jmdbase.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Client")]
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Client
        [HttpGet]
        public async Task<IActionResult> GetClient()
        {
            List<Client> Items = await _context.Client.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Client> payload)
        {
            Client client = payload.value;
            _context.Client.Add(client);
            _context.SaveChanges();
            return Ok(client);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Client> payload)
        {
            Client Client = payload.value;
            _context.Client.Update(Client);
            _context.SaveChanges();
            return Ok(Client);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Client> payload)
        {
            Client Client = _context.Client
                .Where(x => x.ClientId == (int)payload.key)
                .FirstOrDefault();
            _context.Client.Remove(Client);
            _context.SaveChanges();
            return Ok(Client);

        }
    }
}