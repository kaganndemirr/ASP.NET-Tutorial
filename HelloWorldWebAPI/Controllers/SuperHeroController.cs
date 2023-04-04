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
            IEnumerable<SuperHero> heroes = await SelectAllHeroes(connection);
            return Ok(heroes);
        }

        [HttpGet("{heroId}")]
        public async Task<ActionResult<SuperHero>> GetHero(int heroId)
        {
            var hero = await connection.QueryFirstAsync<SuperHero>("select * from super_hero where id = @Id", new { Id = heroId });
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> CreateHero(SuperHero hero)
        {
            await connection.ExecuteAsync("insert into super_hero (Name, FirstName, LastName, place) values (@Name, @FirstName, @LastName, @Place)", hero);
            return Ok(await SelectAllHeroes(connection));
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero hero)
        {
            await connection.ExecuteAsync("update super_hero set Name = @Name, FirstName = @FirstName, LastName = @LastName, Place = @Place where id = @Id", hero);
            return Ok(await SelectAllHeroes(connection));
        }


        [HttpDelete("{heroId}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(SuperHero hero)
        {
            await connection.ExecuteAsync("delete from super_hero where id = @Id", new { Id = heroId });
            return Ok(await SelectAllHeroes(connection));
        }

        private static async Task<IEnumerable<SuperHero>> SelectAllHeroes(SqlConnection connection)
        {
            return await connection.QueryAsync<SuperHero>("select * from super_hero");
        }
    }
}
