
namespace AssignmentAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using AssignmentAPI.Models;
    using AssignmentAPI.Repository;
    using System.Threading.Tasks;
    using System;
    using Microsoft.Extensions.Logging;
    using Microsoft.AspNetCore.Authorization;

    [ApiController]
    [Route("[controller]")]

    public class SquadController: ControllerBase
    {
        private readonly SquadRepository _squadRepository;

        public SquadController(IConfiguration configuration)
        {
            _squadRepository = new SquadRepository(configuration);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_squadRepository.PlayerDetails());
        }

        [HttpPost]
        public IActionResult Post(Squad squad)
        {
            return Ok(_squadRepository.AddPlayer(squad));
        }
        [HttpPut]
        public IActionResult Put(Squad squad, int id)
        {
            return Ok(_squadRepository.UpdatePlayerInfo(squad, id));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_squadRepository.RemovePlayer(id));
        }
    }
}
