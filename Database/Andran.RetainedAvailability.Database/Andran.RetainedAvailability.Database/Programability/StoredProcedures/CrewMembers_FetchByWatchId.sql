CREATE PROCEDURE [dbo].[CrewMembers_FetchByWatchId]
	@watchId uniqueidentifier
AS
	SELECT *
	FROM CrewMember cm
	INNER JOIN Link_CrewMember_Watch lcmw
		ON lcmw.CrewMemberID = cm.Id
	WHERE lcmw.WatchID = @watchId
RETURN 0
