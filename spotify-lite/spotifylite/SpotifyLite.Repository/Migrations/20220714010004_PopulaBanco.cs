using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpotifyLite.Repository.Migrations
{
    public partial class PopulaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Albums (Id,Name,Description,BandName,Band_DateJoined,ReleaseDate) VALUES ('0410B075-3A60-4091-AC41-6D394604832F', 'Tornado Muito Nervoso 2', 'Melhor album da furacão 2000', 'Furação 2000', '2000-01-01 00:00:00.0000000', '2000-01-01 00:00:00.0000000')");
            migrationBuilder.Sql("INSERT INTO Musics (Id,Name,DateAdded,Duracao,AlbumId) VALUES ('0CB3F707-E6AD-4DBD-A13F-0DBDD54C2F64', 'Dança da motinha', '2022-07-03 00:00:00.0000000', '304.00', '0410B075-3A60-4091-AC41-6D394604832F')");
            migrationBuilder.Sql("INSERT INTO Users (Id,Name,NickName,DateOfBirth,Photo,CPF, Email, Country, Gender, Password) VALUES ('14F8E3F2-0DA1-4F2F-8D6C-86A4893442D7', 'Luis', 'DjLuis', '2000-01-01 00:00:00.0000000', 'c://photo//pic001.jpg', '57191529032', 'teste@teste.com', 'Brasil', 'Masculino', '123456')");
            migrationBuilder.Sql("INSERT INTO UserFavoriteMusics (Id,MusicId,UserId,FavoritedAt) VALUES ('483876AD-0540-4CFB-87D3-DF7FB67E35A9', '0CB3F707-E6AD-4DBD-A13F-0DBDD54C2F64', '14F8E3F2-0DA1-4F2F-8D6C-86A4893442D7', '2022-07-03 00:00:00.0000000')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Albums");
            migrationBuilder.Sql("DELETE FROM Musics");
            migrationBuilder.Sql("DELETE FROM Users");
            migrationBuilder.Sql("DELETE FROM UserFavoriteMusics");
        }
    }
}
