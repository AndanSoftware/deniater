/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


INSERT INTO LT_ContactType (ContactType)
VALUES ('IssuedPhone'),
		('HomePhone')
GO
INSERT INTO LT_OfflineHourReason (Reason)
VALUES ('Not Enough Crew'),
		('Skills Requirements Not Met')
GO
INSERT INTO LT_UnavailabilityReason(Symbol, Reason)
VALUES ('M', 'Medical')
		, ('C', 'Course')
GO
INSERT INTO LT_CrewMemberStatus (Status)
VALUES ('Active')
		, ('On Leave')
		, ('Inactive')