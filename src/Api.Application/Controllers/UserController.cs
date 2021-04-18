using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Interfaces.Services.User;
using System.Net;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
<<<<<<< HEAD
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        // GET: api/User
        [HttpGet]
        public async Task<ActionResult> GetAll()
=======
        // GET: api/User
        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] IUserService service)
>>>>>>> 085d90f152ab68976c54bd3dd051f4cab51cb51f
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
<<<<<<< HEAD
                return Ok(await _service.GetAll().ConfigureAwait(false));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
=======
                return Ok(await service.GetAll().ConfigureAwait(false));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
>>>>>>> 085d90f152ab68976c54bd3dd051f4cab51cb51f
        }
    }
}
