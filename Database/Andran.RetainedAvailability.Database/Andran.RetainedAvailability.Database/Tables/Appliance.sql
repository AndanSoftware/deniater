﻿CREATE TABLE [dbo].[Appliance]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(30) NOT NULL, 
    [MinimumCrewCount] SMALLINT NOT NULL, 
    [MaximumCrewCount] SMALLINT NOT NULL
)
