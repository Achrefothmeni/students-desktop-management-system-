CREATE TABLE [dbo].[enseignants] (
    [idEns]  INT           IDENTITY (1, 1) NOT NULL,
    [nom] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([idEns] ASC)
);

