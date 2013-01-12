CREATE TABLE [dbo].[Link_CrewMember_Skill]
(
	[CrewMemberId] UNIQUEIDENTIFIER NOT NULL , 
    [SkillId] INT NOT NULL, 
    PRIMARY KEY ([CrewMemberId], [SkillId])
)
