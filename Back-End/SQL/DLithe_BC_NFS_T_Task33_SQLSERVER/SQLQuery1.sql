use MVC

create table Dept
(
Dno int PRIMARY KEY,
Dname varchar(25)
)

insert into Dept values (2, 'DOTNET')
insert into Dept values (1, 'JAVA')
insert into Dept values (3, 'PYTHON')

select * from Dept

create table Emp
(
Eid int PRIMARY KEY,
Ename varchar(25),
Dno int FOREIGN KEY references Dept(Dno)
)

insert into Emp values (1001, 'Sahil', 1)
insert into Emp values (1002, 'Kundan', 2)

select * from emp


/*check contraint*/
create table Project
(
Prjno int PRIMARY KEY,
Prjname varchar(25) CHECK (Prjname like 'P1%'),
Prjclient varchar(25) DEFAULT 'ABC'
)

insert into Project values (1, 'P100', 'TE')
insert into Project (Prjno, Prjname) values (2, 'P1002')

select * from project

/*Unique key*/
create table DLithe_Trainees
(
TID int PRIMARY KEY,
TNAME varchar(30) UNIQUE,
TSALARY int DEFAULT 35000,
TADDRESS varchar(50),
TDEPT varchar(10) CHECK(TDEPT like 'DIT%')
)