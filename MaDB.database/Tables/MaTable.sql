CREATE TABLE [dbo].[MaTable]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NCHAR(50) NOT NULL, 
    [Prenom] NCHAR(50) NOT NULL, 
    [Annee] INT NOT NULL, 
    CONSTRAINT [PK_MaTable] PRIMARY KEY ([Id]),
)
