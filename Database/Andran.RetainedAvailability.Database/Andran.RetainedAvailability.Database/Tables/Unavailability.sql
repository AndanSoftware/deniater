CREATE TABLE [dbo].[Unavailability]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StaffId] UNIQUEIDENTIFIER NOT NULL, 
    [StartDateTime] DATETIME NOT NULL, 
    [EndDateTime] DATETIME NOT NULL, 
    [UnavailabilityReasonId] INT NOT NULL, 
    [Notes] VARCHAR(300) NULL
)
