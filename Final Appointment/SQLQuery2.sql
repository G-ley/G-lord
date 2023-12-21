Create database appointment

use appointment

CREATE TABLE Users (
    UserID int identity(1,1) primary key,
    Username VARCHAR(50)  NOT NULL,
    UserPassword VARCHAR(50) NOT NULL,
	firstName VARCHAR(50) NOT NULL,
	lastName VARCHAR(50) NOT NULL,
	age int NOT NULL,
	UserAddress VARCHAR(100) NOT NULL,
	UserRole VARCHAR(50) NOT NULL,
);

INSERT into Users (Username, UserPassword, firstName, lastName, age, UserAddress, UserRole) values ('Admin','admin123','G-lord','Hiyas',20,'Basak LLC','Admin')
