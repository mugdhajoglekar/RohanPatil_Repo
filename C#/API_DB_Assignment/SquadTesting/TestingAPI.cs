namespace SquadTesting
{
    using System;
    using Xunit;
    using AssignmentAPI.Models;
    using AssignmentAPI.Repository;
    using AssignmentAPI.Controllers;
    using Microsoft.Extensions.Configuration;
    using FluentAssertions;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;

    public class TestingAPI
    {
        private readonly SquadRepository _squadRepository;
        private readonly SquadController _squadAsync;
        public TestingAPI(ILogger<SquadRepository> logger, IConfiguration configuration)
        {
            //var _squadRepository = new SquadRepository(configuration);
            var _squadAsync = new SquadController(logger, configuration);
        }

        //like integration testing
        [Fact]
        public void TestForGet()
        {
            var result = _squadRepository.PlayerDetails();
            Assert.Equal("Bukayo Saka", result.First().Name);
        }

        //standard unit testing
        [Fact]
        public void TestGet_ReturnsOK()
        {
            //since GetAsync() is commented in cotroller file thats why its giving not accesible warning
            var result = _squadAsync.GetAsync();
            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(Task<IActionResult>));
        }

        [Fact]
        public void TestForPost(Squad squad)
        {
            var result = _squadRepository.AddPlayer(squad);
            Assert.Equal("true", result.ToString());
        }

        [Fact]
        public void TestForPut(Squad squad, int id)
        {
            var result = _squadRepository.UpdatePlayerInfo(squad, id);
            Assert.Equal("true", result.ToString());
        }
    }
}
    