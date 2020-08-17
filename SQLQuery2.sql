create database magneqapp
use magneqapp
create table users(username varchar(20),password varchar(10), constraint pk primary key(username,password));
create table students(rno int PRIMARY KEY IDENTITY(2000,1) NOT NULL,password varchar(30) default '12345',sname varchar(50),course varchar(30),collegename varchar(50),mobileno varchar(10), email varchar(30),city varchar(30),placementstatus varchar(30) default 'unplaced')
create table fee(rno int foreign key references students(rno),totalfee money,feepaid money)
create table placementinfo(rno int,sname varchar(50),compname varchar(50),location varchar(30),package money,placementstatus varchar(30))
insert into users values('suleman',12345)
drop table users
delete students where rno=2001
select placementstatus from students where ; --for specific row
select *from students where rno=2004; --for specific roll no.
select *from placementinfo;
delete from students where rno=2012 and sname='sam';
select *from placementinfo
--delete students,placementinfo from students inner join placementinfo on placementinfo.ref=students.id where students.id=@trno
SELECT sname,placementstatus from students where placementstatus='placed';
insert into students(sname,course,collegename,mobileno,email,city) values('sam','c','liet','8121795121','sul12@gmail.com','hyd');
create table course(cid int primary key ,cname varchar(30),duration varchar(50),fee varchar(30));
insert into course values(1,'C','2months','5000');
select *from students
drop table course;
drop table placementinfo;

create table COUNTRIES
(CID INT PRIMARY KEY, CNAME VARCHAR(20), CC VARCHAR(3))

create table STATES
(SID INT PRIMARY KEY, SNAME VARCHAR(20), SC VARCHAR(3), CID INT)

ALTER TABLE [dbo].[placementinfo] with CHECK ADD CONSTRAINT [FK_placementinfo_students1] FOREIGN KEY([rno])
REFERENCES [dbo].[students]([rno])
ON DELETE CASCADE
GO
Alter table [dbo].[placementinfo] check constraint [FK_placementinfo_students1]
go