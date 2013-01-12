CREATE TABLE [dbo].[CrewMember]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(30) NOT NULL, 
    [LastName] VARCHAR(30) NOT NULL, 
    [CrewMemberStatusId] SMALLINT NOT NULL 
)
