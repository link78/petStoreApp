CREATE TABLE [dbo].[Pet] (
    [PetId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (MAX) NULL,
    [OwnerId] INT            NOT NULL,
    [Age]     INT            NOT NULL,
    [Picture] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED ([PetId] ASC),
    CONSTRAINT [FK_Pet_Owner_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Owner] ([OwnerId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Pet_OwnerId]
    ON [dbo].[Pet]([OwnerId] ASC);

