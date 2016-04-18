CREATE TABLE [dbo].[User] (
    [Id]       INT        NOT NULL,
    [Name]     NCHAR (10) NOT NULL,
    [Role]     INT        NOT NULL,
    [Password] NCHAR (10) NOT NULL,
    CONSTRAINT [PK__User__3214EC0754763AA4] PRIMARY KEY CLUSTERED ([Id] ASC)
);



