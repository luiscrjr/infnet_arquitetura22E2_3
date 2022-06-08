IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Albums] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(150) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [Backdrop] nvarchar(1024) NOT NULL,
    [BandName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Albums] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(200) NOT NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [Photo] nvarchar(500) NOT NULL,
    [CPF] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Songs] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(150) NOT NULL,
    [Duracao] decimal(18,2) NOT NULL,
    [AlbumId] uniqueidentifier NULL,
    CONSTRAINT [PK_Songs] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Songs_Albums_AlbumId] FOREIGN KEY ([AlbumId]) REFERENCES [Albums] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserFavoriteSongs] (
    [Id] uniqueidentifier NOT NULL,
    [SongId] uniqueidentifier NOT NULL,
    [UserId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_UserFavoriteSongs] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserFavoriteSongs_Songs_SongId] FOREIGN KEY ([SongId]) REFERENCES [Songs] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserFavoriteSongs_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Songs_AlbumId] ON [Songs] ([AlbumId]);
GO

CREATE INDEX [IX_UserFavoriteSongs_SongId] ON [UserFavoriteSongs] ([SongId]);
GO

CREATE INDEX [IX_UserFavoriteSongs_UserId] ON [UserFavoriteSongs] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220608001611_CreateDatabase', N'6.0.5');
GO

COMMIT;
GO

