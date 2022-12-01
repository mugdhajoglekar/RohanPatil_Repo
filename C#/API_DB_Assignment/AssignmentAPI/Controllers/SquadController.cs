
namespace AssignmentAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using AssignmentAPI.Models;
    using AssignmentAPI.Repository;
    using System.Threading.Tasks;
    using System;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]

    public class SquadController: ControllerBase
    {
        private readonly SquadRepository _squadRepository;
        private readonly ILogger<SquadRepository> _logger;

        public SquadController(ILogger<SquadRepository> logger, IConfiguration configuration)
        {
            _squadRepository = new SquadRepository(logger, configuration);
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Inside Get controller");
            return Ok(_squadRepository.PlayerDetails());
        }

        ////for async
        //[HttpGet]
        //public async Task<IActionResult> GetAsync()
        //{
        //    try
        //    {
        //        var result = await _squadRepository.PlayerDetailsAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception err)
        //    {
        //        return StatusCode(500, err.Message);
        //    }
        //}

        /// <summary>
        ////for dapper
        /// </summary>
        /// <param name="squad"></param>
        /// <returns></returns>
        //[HttpGet]
        //public IActionResult GetDapper()
        //{
        //    return Ok(_squadRepository.PlayerDetailsDapper());
        //}

        [HttpPost]
        public IActionResult Post(Squad squad)
        {
            _logger.LogInformation("Inside Post controller");
            return Ok(_squadRepository.AddPlayer(squad));
        }
        [HttpPut]
        public IActionResult Put(Squad squad, int id)
        {
            _logger.LogInformation("Inside Put controller");
            return Ok(_squadRepository.UpdatePlayerInfo(squad, id));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Inside Delete controller");
            return Ok(_squadRepository.RemovePlayer(id));
        }
    }
}
