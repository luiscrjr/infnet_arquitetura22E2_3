﻿using MediatR;
using SpotifyLite.Application.Album.Dto;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class CreateAlbumCommand : IRequest<CreateAlbumCommandResponse>
    {
        public AlbumInputDto Album { get; set; }

        public CreateAlbumCommand(AlbumInputDto album)
        {
            Album = album;
        }

    }
}
