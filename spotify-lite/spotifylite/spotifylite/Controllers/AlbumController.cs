using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpotifyLite.Application.Album.DTOs;
using SpotifyLite.Application.Album.Handler.Commands;
using SpotifyLite.Application.Album.Handler.Queries;

namespace SpotifyLite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "user-policy")]
    public class AlbumController : ControllerBase
    {
        public IMediator Handler { get; }

        public AlbumController(IMediator handler)
        {
            Handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AlbumInputDto albumDto)
        {
            var result = await Handler.Send(new CreateAlbumCommand(albumDto));

            return Created($"/{result.Album.Id}", result.Album);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await Handler.Send(new GetAllQueryCommand());

            return Ok(result.Albums);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] AlbumInputDto albumDto)
        {
            var result = await Handler.Send(new UpdateAlbumCommand(albumDto));

            return Ok(result.Album);
        }

        [HttpDelete("{albumId}")]
        public async Task<IActionResult> DeleteAsync(Guid albumId)
        {
            await Handler.Send(new DeleteAlbumCommand(albumId));

            return NoContent();
        }

    }
}
