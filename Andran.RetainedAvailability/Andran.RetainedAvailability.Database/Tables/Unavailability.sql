CREATE TABLE [dbo].[Unavailability]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StaffId] UNIQUEIDENTIFIER NOT NULL, 
    [StartDateTime] DATETIME NOT NULL, 
    [EndDateTime] DATETIME NOT NULL, 
    [UnavailabilityReasonId] NCHAR(10) NOT NULL, 
    [Notes] VARCHAR(300) NULL
)
