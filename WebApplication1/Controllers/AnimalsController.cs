using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<AnimalDTO>> GetAnimals()
        {
            SqlConnection con = new SqlConnection();

            return Ok();
        }
    }
}