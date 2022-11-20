create database Parking
go

use Parking

create table Cards
(
id int primary key,
[CountCards] int not null,
[ConeyInTheTerminal] int not null
);

create table Cars
(
id int primary key,
carNumber nvarchar(10) not null,
timeStart datetime not null,
timeEnd datetime,
isPaid bit
);

insert into Cards values
(1, 50, 10000)