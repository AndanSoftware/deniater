CREATE TABLE [dbo].[Link_CrewMember_Watch]
(
	[CrewMemberId] UNIQUEIDENTIFIER NOT NULL , 
    [WatchId] UNIQUEIDENTIFIER NOT NULL, 
    PRIMARY KEY ([WatchId], [CrewMemberId])
)
