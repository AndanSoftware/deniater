CREATE TABLE [dbo].[Link_CrewMember_ContactType]
(
    [CrewMemberId] UNIQUEIDENTIFIER NOT NULL, 
    [ContacTypeId] SMALLINT NOT NULL, 
    [ContactValue] VARCHAR(30) NOT NULL, 
    CONSTRAINT [PK_Link_CrewMember_ContactType] PRIMARY KEY ([ContacTypeId], [CrewMemberId]) 
)
