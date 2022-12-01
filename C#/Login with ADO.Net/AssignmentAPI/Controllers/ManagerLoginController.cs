namespace AssignmentAPI.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.IdentityModel.Tokens;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Security.Cryptography;
    using System.Threading.Tasks;
    using System;
    using AssignmentAPI.DTO;
    using AssignmentAPI.Controllers;
    using AssignmentAPI.Repository;
    using AssignmentAPI.Models;
    using System.Linq;
    using Microsoft.Extensions.Configuration;
    using System.Data.SqlClient;

    public class ManagerLoginController : ControllerBase
    {
        public static Manager manager = new Manager();
        private readonly IConfiguration configuration;
        private readonly SquadRepository _squadRepository;

        public ManagerLoginController(IConfiguration configuration)
        {
            _squadRepository = new SquadRepository(configuration);
        }

        [HttpPost("register")]
        public async Task<ActionResult<Manager>> Register(DTO_Manager request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            manager.Username = request.Username;
            manager.PasswordHash = passwordHash;
            manager.PasswordSalt = passwordSalt;

            return Ok(manager);
        }


        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(DTO_Manager request)
        {
            if (manager.Username != request.Username)
            {
                return BadRequest("Manager not found !");
            }
            if (!VerifyPasswordHash(request.Password, manager.PasswordHash, manager.PasswordSalt))
            {
                return BadRequest("Entered Credentials are wrong");
            }

            string token = CreateToken(manager);

            return Ok(token);
        }
        //Methods 
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
        private string CreateToken(Manager manager)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, manager.Username),
                new Claim(ClaimTypes.Role,"Admin") // Role
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                 configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                 claims: claims,
                 expires: DateTime.Now.AddDays(1),
                 signingCredentials: cred);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        [HttpGet, Authorize]
        public IActionResult Get()
        {
            return Ok(_squadRepository.PlayerDetails());
        }

    }
}
