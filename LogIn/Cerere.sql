CREATE TABLE [dbo].[Cerere]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Cantitate] INT NULL, 
    [Grupa] VARCHAR(50) NULL, 
    [RH] VARCHAR(50) NULL, 
    [Nume pacient] VARCHAR(50) NULL, 
    [Prenume pacient] VARCHAR(50) NULL, 
    [Nr. Card sanatate] VARCHAR(50) NULL, 
    [id_medic] INT NULL
)
