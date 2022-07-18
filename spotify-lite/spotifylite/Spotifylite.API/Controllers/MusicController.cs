using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpotifyLite.Application.Music.Handler.Commands;
using SpotifyLite.Application.Music.Handler.Queries;

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

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await Handler.Send(new GetAllQueryCommand());

            return Ok(result.Musics);
        }

        [HttpDelete("{musicId}")]
        public async Task<IActionResult> DeleteAsync(Guid musicId)
        {
            await Handler.Send(new DeleteMusicCommand(musicId));

            return NoContent();
        }

    }
}
