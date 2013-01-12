CREATE TABLE [dbo].[OfflineHour]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UnavailabilityId] UNIQUEIDENTIFIER NOT NULL, 
    [OfflineHourReasonId] INT NOT NULL, 
    [ApplianceId] UNIQUEIDENTIFIER NOT NULL, 
    [StartDateTime] DATETIME NOT NULL, 
    [EndDateTime] DATETIME NOT NULL,
    [AuditCreatedBy] UNIQUEIDENTIFIER NOT NULL,
	[AuditCreatedDate] DATETIME NOT NULL
)
