CREATE TABLE [dbo].[Donator] (
    [Id]                   INT          NOT NULL,
    [Nr_card_sanatate]     VARCHAR (50) NOT NULL,
    [Parola]               VARCHAR (50) NULL,
    [Nume]                 VARCHAR (50) NULL,
    [Prenume]              VARCHAR (50) NULL,
	[Data_ultimaDonare]    DATE NULL,
    [Data_nasterii]        VARCHAR (50) NULL,
    [Domiciliu]            VARCHAR (50) NULL,
    [Localitate]           VARCHAR (50) NULL,
    [Judet]                VARCHAR (50) NULL,
    [Resedinta]            VARCHAR (50) NULL,
    [LocalitateR]          VARCHAR (50) NULL,
    [JudetR]               VARCHAR (50) NULL,
    [Email]                VARCHAR (50) NULL,
    [Telefon]              VARCHAR (10) NULL,
    [Pers_pt_care_doneaza] VARCHAR (50) NULL,
    CONSTRAINT [PK_Donator] PRIMARY KEY CLUSTERED ([Nr_card_sanatate] ASC)
);

