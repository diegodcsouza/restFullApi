CREATE TABLE IF NOT EXISTS books(
	`id` VARCHAR(50) NOT NULL,
	`Author` longtext,
	`LaunchDate` datetime NOT NULL,
	`Price` decimal(65,2) NOT NULL,
	`Title` longtext,
	PRIMARY KEY(`id`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;