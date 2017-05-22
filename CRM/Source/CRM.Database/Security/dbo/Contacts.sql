﻿CREATE TABLE [dbo].[Contacts]
(
	[ContactId] INT NOT NULL PRIMARY KEY identity(1,1),
	[FullName] varchar(200) not null,
	[CompanyName] varchar(150) null,
	[Position] varchar(100) null,
	[Country] varchar(50) null,
	[Email] varchar(100) not null,
	[Guid] uniqueidentifier null default newid()
)