using Challenge.Clear.Application.Parameters;
using Challenge.Clear.Core.Application.Exeception;
using Challenge.Clear.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challengue.Clear.Web.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieServices _movieServices;

        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        [HttpGet("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get([FromQuery] MoviesFilter filter)
        {
            return Ok(await _movieServices.GetMoviesAsync(filter));
        }

    }
}
