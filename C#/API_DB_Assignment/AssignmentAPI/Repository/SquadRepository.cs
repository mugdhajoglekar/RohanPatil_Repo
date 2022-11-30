namespace AssignmentAPI.Repository
{
    using System.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using AssignmentAPI.Models;
    using System.Data;
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Dapper;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;

    public class SquadRepository
    {
        private readonly string _connectionString;
        private readonly ILogger<SquadRepository> _logger;

        public IConfiguration Configuration { get; }

        public SquadRepository(ILogger<SquadRepository> logger, IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            _logger = logger;
        }
        
        public IEnumerable<Squad> PlayerDetails()
        {
            _logger.LogInformation("Getting player details");
            var players = new List<Squad>();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "Select * from Squad";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var squad = new Squad()
                {
                    Id = Convert.ToInt32(dataTable.Rows[i]["Id"]),
                    Name = dataTable.Rows[i]["Name"].ToString(),
                    Age = Convert.ToInt32(dataTable.Rows[i]["Age"]),
                    Position = (string)dataTable.Rows[i]["Position"],
                    CEY = Convert.ToInt32(dataTable.Rows[i]["CEY"])
                };
                players.Add(squad);
            }
            return players;
        }

        //using async
        public async Task<IEnumerable<Squad>> PlayerDetailsAsync()
        {
            var sql = "select * from Squad";
            using (var connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnection")))
            {
                var players = await connection.QueryAsync<Squad>(sql);
                return players.ToList();
            }
        }

        //using dapper
        public IEnumerable<Squad> PlayerDetailsDapper()
        {
            string sql = "select * from Products";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<Squad>(sql);
                return result.ToList();
            }
        }
        public bool AddPlayer(Squad squad)
        {
            _logger.LogInformation("Inserting player into database");
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Insert into Squad (Name, Age, Position, CEY) Values ('{squad.Name}', " +
                             $"'{squad.Age}', '{squad.Position}', '{squad.CEY}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
        }
        public bool UpdatePlayerInfo(Squad squad, int id)
        {
            _logger.LogInformation("Updating player info of {id}", id);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Update Squad SET Name='{squad.Name}', Age='{squad.Age}', Position='{squad.Position}', CEY='{squad.CEY}' Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
        }
        public bool RemovePlayer(int id)
        {
            _logger.LogInformation("Removing player whose id is {id}", id);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Delete From Squad Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
        }
    }
}
