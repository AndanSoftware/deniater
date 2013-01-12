CREATE PROCEDURE [dbo].[Appliance_Create]
	@applianceId UNIQUEIDENTIFIER
	, @name VARCHAR(30)
	, @minimumCrewCount SMALLINT
	, @maximumCrewCount SMALLINT

AS
	INSERT INTO Appliance (Id
							, Name
							, MinimumCrewCount
							, MaximumCrewCount)
	VALUES (@applianceId
			, @name
			, @minimumCrewCount
			, @maximumCrewCount)
