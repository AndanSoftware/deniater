CREATE PROCEDURE Appliance_Fetch
	@applianceID UNIQUEIDENTIFIER 
AS
BEGIN
	SELECT *
	FROM Appliance
	WHERE Appliance.Id = @applianceID
END