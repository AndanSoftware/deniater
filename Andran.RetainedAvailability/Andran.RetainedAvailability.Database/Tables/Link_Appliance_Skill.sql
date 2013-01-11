CREATE TABLE [dbo].[Link_Appliance_Skill]
(
	[ApplianceId] UNIQUEIDENTIFIER NOT NULL , 
    [SkillId] INT NOT NULL, 
    PRIMARY KEY ([SkillId], [ApplianceId]), 
    CONSTRAINT [FK_Link_Appliance_Skill_ToTableSkill] FOREIGN KEY ([SkillId]) REFERENCES [Skill]([Id]), 
    CONSTRAINT [FK_Link_Appliance_Skill_ToTableAppliance] FOREIGN KEY ([ApplianceId]) REFERENCES [Appliance]([ApplianceId]) 
)
