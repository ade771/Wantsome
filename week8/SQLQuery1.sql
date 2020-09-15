use[DB];
--am creat un tabel points

CREATE TABLE Points 
(
[x coord] float,
[y coord] float
);

-- verificam daca este 
select * from Points;
exec sp_help Points;

insert into Points values
(1.3, 1.4), (1.5,1.6), (1.7, 1.8);

select * from Points;


--ne mai uitam la informatii din tabel
exec sp_help Points;
-- am creat dublicate, in general un table contine o cheie prin. , iar acest lucru nu se mai putea face

insert into Points values
(1.3, 1.4), (1.5,1.6), (1.7, 1.8);
select * from Points;

create table [Points List]
(
[position] int identity primary key,
[x coord] float,
[y coord] float

);
select* from [Points List]; 
insert into [Points List] values
(1.3, 1.4), (1.5,1.6), (1.7, 1.8);
select * from [Points List];

insert into [Points List] values
(1.3, 1.4), (1.5,1.6), (1.7, 1.8);
select * from [Points List];

--am creat people table
create table people
(
[first name] varchar(40) not null,
[last name] varchar (40) not null,
[favorite color] varchar(15) null default 'willow blue',
constraint people_pk primary key ([first name], [last name])
);

select * from people;

insert into people values
('Joe', 'Smith', 'green'),
('Jane', 'Jones', null),
('Jake', 'White', default);
select* from people;

--cum adaugam o coloana noua in tabel
alter table people add [favorite food] varchar(25) null 
default 'hot dog' with values;

select *from people;
insert into people values
('Jack', 'Black', 'white', 'wheat sprouts');

select *from peo ple;