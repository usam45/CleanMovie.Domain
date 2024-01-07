using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _Service;

        public MoviesController(IMovieService service) 
        {
            _Service = service;
        }
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _Service.GetAllMovies();
            return Ok(moviesFromService);
        }

       
    }
}
