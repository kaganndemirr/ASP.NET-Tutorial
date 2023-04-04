using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace HelloWorldWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        SqlConnection connection;

        public SuperHeroController(IConfiguration config) 
        {
            _configuration = config;
            connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllSuperheroes()
        {
            var heroes = await connection.QueryAsync<SuperHero>("select * from super_hero");
            return Ok(heroes);
        }

        [HttpGet("{heroId}")]
        public async Task<ActionResult<SuperHero>> GetHero(int heroId)
        {
            var hero = await connection.QueryFirstAsync<SuperHero>("select * from super_hero where id = @Id", new {Id = heroId});
            return Ok(hero);
        }
    }
}
