using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpotifyLite.Repository.Migrations
{
    public partial class CargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Albums (Id,Name,Description,Backdrop,BandName,ReleaseDate) VALUES ('9bfe8a0d-2b6d-486e-a407-1f5f0c1e5da2', 'Pro Dia Nascer Feliz', 'Album do Cazuza na época do Barão Vermelho', 'Capa do Album - Cazuza Pro Dia Nascer Feliz', 'Barão Vermelho', '2000-01-01 00:00:00.0000000')");
            migrationBuilder.Sql("INSERT INTO Songs (Id,Name,Duracao,AlbumId) VALUES ('1ed080d2-0f28-4d93-aebc-95cbc8734745', 'Pro dia Nascer Feliz', '150.00', '9bfe8a0d-2b6d-486e-a407-1f5f0c1e5da2')");
            migrationBuilder.Sql("INSERT INTO Users (Id,Name,DateOfBirth,Photo,CPF, Email, Password) VALUES ('46c28818-bf2a-41e3-9207-793044bfda58', 'Vinicius Ventura', '1990-08-19 00:00:00.0000000', 'c://photos//vinicius.jpg', '42467713091', 'vinicius@ventura.com', '1234')");
            migrationBuilder.Sql("INSERT INTO UserFavoriteSongs (Id,SongId,UserId) VALUES ('e1a07970-e7eb-479a-9842-cd2048833b90', '1ed080d2-0f28-4d93-aebc-95cbc8734745', '46c28818-bf2a-41e3-9207-793044bfda58')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Albums");
            migrationBuilder.Sql("DELETE FROM Songs");
            migrationBuilder.Sql("DELETE FROM Users");
            migrationBuilder.Sql("DELETE FROM UserFavoriteSongs");
        }
    }
}
