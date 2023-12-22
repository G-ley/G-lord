Create database appointment

use appointment

create table  (
 UserId int identity(1,1) primary key,
 ClientName varchar(50) not null,
 ClientId varchar(50) not null,
 ClientPhone varchar(50) not null,
);

insert into dashboard (ClientName, ClientId, ClientPhone) values ('G-lord','123','09123')
