CREATE TABLE dbo.Animal
	(TagID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Species varchar(25) NOT NULL,
	FoodCost money NULL,
	Name text NULL,
	Shots bit NOT NULL,
	Adopted bit NOT NULL,
	LastUpdate timestamp NOT NULL,
	Room varchar(25) NULL)
GO
