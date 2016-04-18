CREATE TABLE [dbo].[ImageCharacteristicsData] (
    [Id]                  INT        NOT NULL,
    [ImageID]             INT        NOT NULL,
    [CharacteristicID]    NCHAR (10) NOT NULL,
    [CharacteristicValue] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

