CREATE DATABASE Tournaments;
use master;
use Tournaments;
DROP DATABASE Tournaments;
--Creates the Prizes Table
USE [Tournaments]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prizes](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [PlaceNumber] [int] NOT NULL,
    [PlaceName] [nvarchar](50) NOT NULL,
    [PrizeAmount] [money] NOT NULL,
    [PrizePercentage] [float] NOT NULL,
    CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED
    (
        [id] ASC
    ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON
    ) ON [PRIMARY]
)
GO

ALTER TABLE [dbo].[Prizes] ADD CONSTRAINT [DF_Prizes_PrizeAmount] DEFAULT ((0)) FOR [PrizeAmount]
GO

ALTER TABLE [dbo].[Prizes] ADD CONSTRAINT [DF_Prizes_PrizePercentage] DEFAULT ((0)) FOR [PrizePercentage]


----Stored Procedure
--CREATE PROCEDURE dbo.spTestPerson
--	@LastName nvarchar(100),
--AS
--BEGIN
--	SET NOCOUNT ON;
--	SELECT * FROM dbo.TestPerson
--	WHERE LastName = @LastName;
--END 
--GO

----Se ejecuta con:
--exec dbo.spTestPerson 'Corey'


--===============================================================
CREATE PROCEDURE dbo.spPrizes_Insert
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON
		INSERT INTO dbo.Prizes(PlaceNumber,PlaceName,PrizeAmount,PrizePercentage)
		VALUES(@PlaceNumber,@PlaceName,@PrizeAmount,@PrizePercentage);

		SELECT @id = SCOPE_IDENTITY();
END
GO
=================================================================

CREATE TABLE Tournaments(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TournamentName VARCHAR(50) NOT NULL,
	EntryFee DECIMAL
);

CREATE TABLE Teams(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TeamName VARCHAR(50)
);

CREATE TABLE TournamentEntries(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TournamentId INT,
	TeamId INT,
	FOREIGN KEY(TournamentId) REFERENCES Tournaments(id) ON DELETE SET NULL,
	FOREIGN KEY(TeamId) REFERENCES Teams(id) ON DELETE SET NULL
);

CREATE TABLE Prizes(
	id INT IDENTITY(1,1) PRIMARY KEY,
	PlaceNumber INT,
	PlaceName VARCHAR(50),
	PrizeAmount MONEY DEFAULT 0.00,
	PrizePercentage FLOAT,	
);

CREATE TABLE TournamentPrizes(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TournamentId INT,
	PrizeId INT,
	FOREIGN KEY(TournamentId) REFERENCES Tournaments(id) ON DELETE SET NULL,
	FOREIGN KEY(PrizeId) REFERENCES Prizes(id) ON DELETE SET NULL
);

CREATE TABLE People(
	id INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	EmailAddress VARCHAR(50),
	CellphoneNumber VARCHAR(50),
);

CREATE TABLE TeamMembers(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TeamId INT,
	PersonId INT,
	FOREIGN KEY(TeamId) REFERENCES Teams(id) ON DELETE SET NULL,
	FOREIGN KEY(PersonId) REFERENCES People(id) ON DELETE SET NULL
);

CREATE TABLE Matchups (
    id INT IDENTITY(1,1) PRIMARY KEY,
    WinnerId INT,
    MatchupRound INT,
    FOREIGN KEY (WinnerId) REFERENCES Teams(id) ON DELETE SET NULL
);

CREATE TABLE MatchupEntries (
    id INT IDENTITY(1,1) PRIMARY KEY,
    MatchupId INT,
    ParentMatchupId INT,
    TeamCompetingId INT,
    Score FLOAT,
    FOREIGN KEY (MatchupId) REFERENCES Matchups(id) ON DELETE NO ACTION,
    FOREIGN KEY (ParentMatchupId) REFERENCES MatchupEntries(id) ON DELETE NO ACTION,
    FOREIGN KEY (TeamCompetingId) REFERENCES Teams(id) ON DELETE SET NULL
);

