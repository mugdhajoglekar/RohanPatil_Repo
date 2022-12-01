namespace AssignmentAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using AssignmentAPI.Models;
    using AssignmentAPI.Repository;
    using AssignmentAPI.Context;
    using System.Threading.Tasks;
    using System;
    using Microsoft.Extensions.Logging;
    using Microsoft.EntityFrameworkCore;

    [ApiController]
    [Route("[controller]")]
    public class ManagerController : Controller
    {
        private Interface_DB_Context _context;
        public ManagerController(Interface_DB_Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Manager manager)
        {
            _context.Managers.Add(manager);
            await _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var managers = await _context.Managers.ToListAsync();
            if (managers == null)
                return NotFound();
            return Ok(managers);
        }
    }
}
