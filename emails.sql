create database [Email]
go

use [Email]
go


 create table [dbo].[Employee]
(
[ID_Employee] [int] not null 
identity(1,1),
[Login_Employee] [varchar] (32) not null,
[Password_Employee] [varchar] (32) not null,
[Email_Employee] [varchar] (32) not null,
constraint [PK_Employee] primary key clustered 
([ID_Employee] ASC) on [PRIMARY],
constraint [UQ_Login_Employee] unique
([Login_Employee]),
constraint [UQ_Email_Employee] unique
([Email_Employee])
) 
go


insert into [dbo].[Employee] ([Login_Employee],[Password_Employee],[Email_Employee])
values ('chel1', 'Pa$$word', 'dimaderen1@gmail.com'),
('chel2', 'Pa$$word', 'timurmarz@mail.ru'),
('chel3', 'Pa$$word', 'sashka1488@gmail.com'),
('chel4', 'Pa$$word', 'matheush@yandex.ru')
go

select [Email_Employee] from dbo.[Employee];