CREATE TABLE [dbo].[Owner] (
    [OwnerId]     INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (MAX) NULL,
    [LastName]    NVARCHAR (MAX) NULL,
    [email]       NVARCHAR (MAX) NULL,
    [Photo]       NVARCHAR (MAX) NULL,
    [PhoneNumber] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED ([OwnerId] ASC)
);

