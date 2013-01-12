CREATE TABLE [dbo].[LT_UnavailabilityReason]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Symbol] VARCHAR NOT NULL, 
    [ColourHex] VARCHAR(8) NULL, 
    [Icon] VARCHAR(20) NULL, 
    [Reason] NCHAR(20) NOT NULL
)
