CREATE TABLE [dbo].[LT_UnavailabilityReason]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Symbol] VARCHAR NOT NULL, 
    [ColourHex] VARCHAR(8) NULL, 
    [Icon] VARCHAR(20) NULL, 
    [Name] NCHAR(10) NULL
)
