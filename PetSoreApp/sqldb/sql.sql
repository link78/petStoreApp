USE [PetSoreAppDB]
GO

/****** Object: Table [dbo].[Owner] Script Date: 8/13/2020 6:59:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Owner] (
    [OwnerId]     INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (MAX) NULL,
    [LastName]    NVARCHAR (MAX) NULL,
    [email]       NVARCHAR (MAX) NULL,
    [Photo]       NVARCHAR (MAX) NULL,
    [PhoneNumber] NVARCHAR (MAX) NULL
);

GO

CREATE TABLE [dbo].[Pet] (
    [PetId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (MAX) NULL,
    [OwnerId] INT            NOT NULL,
    [Age]     INT            NOT NULL,
    [Picture] NVARCHAR (MAX) NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Pet_OwnerId]
    ON [dbo].[Pet]([OwnerId] ASC);


GO
ALTER TABLE [dbo].[Pet]
    ADD CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED ([PetId] ASC);


GO
ALTER TABLE [dbo].[Pet]
    ADD CONSTRAINT [FK_Pet_Owner_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Owner] ([OwnerId]) ON DELETE CASCADE;


