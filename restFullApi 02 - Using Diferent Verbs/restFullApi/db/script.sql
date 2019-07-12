--CREATE TABLE [dbo].[persons] (
--    [Id]        INT           DEFAULT (NULL) NOT NULL,
--    [FirstName] NVARCHAR (50) DEFAULT (NULL) NULL,
--    [LastName]  VARCHAR (50)  DEFAULT (NULL) NULL,
--    [Address]   VARCHAR (50)  DEFAULT (NULL) NULL,
--    [Gender]    VARCHAR (50)  DEFAULT (NULL) NULL,
--    PRIMARY KEY CLUSTERED ([Id] ASC)
--);

CREATE TABLE `persons` (
	`Id` int(10) UNSIGNED NULL DEFAULT NULL,
	`FirstName` VARCHAR(50) NULL DEFAULT NULL,
	`LastName` VARCHAR(50) NULL DEFAULT NULL,
	`Address` VARCHAR(50) NULL DEFAULT NULL,
	`Gender` VARCHAR(50) NULL DEFAULT NULL
)
ENGINE=InnoDB
;

alter table persons change id int(10) auto_increment primary key;