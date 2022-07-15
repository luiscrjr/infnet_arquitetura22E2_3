using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpotifyLite.Application.User.DTOs;
using SpotifyLite.Application.User.Handler.Commands;
using SpotifyLite.Application.User.Handler.Queries;

namespace SpotifyLite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "user-policy")]
    public class MusicController : ControllerBase
    {
        public IMediator Handler { get; }

        public MusicController(IMediator handler)
        {
            Handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UserInputDto UserDto)
        {
            var result = await Handler.Send(new CreateUserCommand(UserDto));

            return Created($"/{result.User.Id}", result.User);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await Handler.Send(new GetAllQueryCommand());

            return Ok(result.Users);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UserInputDto UserDto)
        {
            var result = await Handler.Send(new UpdateUserCommand(UserDto));

            return Ok(result.User);
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteAsync(Guid userId)
        {
            await Handler.Send(new DeleteUserCommand(userId));

            return NoContent();
        }

    }
}
