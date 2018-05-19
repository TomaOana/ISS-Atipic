CREATE TABLE [dbo].[donare] (
    [Id]                 INT          NOT NULL,
    [id_donator]         VARCHAR (50) NULL,
    [rezultat]           VARCHAR (50) NULL,
    [data_donarii]       DATE         NULL,
    [cantitate]          INT          NULL,
    [grupa]              VARCHAR (4)  NULL,
    [Rh]                 VARCHAR (10) NULL,
    [data_donarii_urmat] DATE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_donare_Donator] FOREIGN KEY ([id_donator]) REFERENCES [dbo].[Donator] ([Nr_card_sanatate])
);

