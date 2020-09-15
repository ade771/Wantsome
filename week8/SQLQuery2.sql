use [Tema1];
-------Book table

CREATE TABLE BOOK (
BOOKID int  NOT NULL,
TITLE VARCHAR (50) NOT NULL,
PUBLISHERID INT,
YEAR INT,
PRICE DECIMAL);

Alter table Book
ADD PRIMARY KEY (BookID)

ALTER TABLE BOOK ADD HardCover VARCHAR (5)
SELECT * FROM BOOK;

------Member
CREATE TABLE MEMBER(
MEMBERID INT Primary Key  NOT NULL,
[FIRSTNAME] VARCHAR(25) NOT NULL,
[LASTNAME] VARCHAR (25) NOT NULL,
[PERMISNUMBER] INT  NOT NULL,
[GENDER] VARCHAR (8) NOT NULL,
[PHONENUMBER] INT  NULL,
[EMAILADDRESS] VARCHAR (25) NULL,
[AddressId] varchar (50) not null);

Select *from MEMBER

----Library table
 create TABLE [LIBRARY]
(
LIBRARYID INT Primary Key  NOT NULL,
[Name] varchar (55) not null,
AddressId varchar (50) not null);
Select *from Library ;

---MemberLibrary table

CREATE TABLE MEMBERLIBRARY (
MEMBERLIBRARYID INT Primary Key NOT NULL,
MEMBERID INT NOT NULL,
LIBRARYID INT NOT NULL,
PERMISNUMBER VARCHAR(20) not null
);

ALTER TABLE MEMBERLIBRARY ADD FOREIGN KEY (MEMBERID ) REFERENCES MEMBER (MEMBERID);

CREATE TABLE REQUEST (
REQUESTID INT  Primary Key NOT NULL,
REQUESTEDBY VARCHAR (20) NOT NULL,
BOOKID INT NOT NULL,
CREATEDDATE DATE DEFAULT GETDATE(),
LIBRARYID int REFERENCES LIBRARY(LIBRARYID)
);

SELECT * FROM REQUEST ;


--Create Address table
CREATE TABLE ADDRESS
(
[AddressId] varchar( 50) not null,
[Street] varchar(30) not null,
[Building number] int not null,
[Building name] varchar null,
[Entrance number] int null,
[Floor] int null,
[Apartment number] int null,
[City] varchar(15) not null,
[Postal code] int not null,
[Country] varchar (15) not null,
[Other details] varchar(50) null
constraint address_pk primary key(AddressId)
);
Select*from [ADDRESS];

--create BookLibrary 

create table BookLibrary
(BookLibraryId int not null,
LibraryId int not null,
BookId int not null,
Quantity int not null
);


--create BookCategory
Create table BookCategory
(BookCategoryId int not null,
BookId int not null,
CategoryId int not null
);

--Create Author

Create table Author
(
AuthorId int Primary Key not null,
FirstName varchar(50) not null,
LastName varchar (50) not null,
);

Select * from Author;

--Create Category

Create table Category
(CategoryId int Primary Key not null,
Name varchar(50) not null);

Select * from Category;

--BooAuthor table
Create table BookAuthor
(
BookCategoryId int not null,
BookId int not null,
AuthorId int primary key not null
);

Alter table Member
add foreign key (AddressId) references  [ADDRESS ](AddressId);

Alter table Library
add foreign key(AddressId) references [ADDRESS](AddressId);

Alter table BookLibrary
add foreign key (BookId) references [Book](BookId);

Alter table BookLibrary
add foreign key (LibraryId) references [Library](LibraryId);

alter table BookCategory
add foreign key (BookId) references Book(BookId);

alter table BookCategory
add foreign key (CategoryId) references Category(CategoryId);

alter table BookAuthor
add foreign key (BookId) references Book(BookId)

alter table BookAuthor
add foreign key (AuthorId) references Author(AuthorId)


insert into Address values ('Strada Pacurari','4',12,'F',1,null,2,'Iasi',500,'Ro',null);
insert into Address values ('Strada Petre Tutea','9',13,'B',2,null,1,'Iasi',600,'Ro',null);

insert into Library values (700511,'BCU','Strada Pacurari')
insert into Library values (700512,'BGA','Strada Petre Tutea')

select LIBRARY.[Name] , ADDRESS.[AddressId],Address.Street, ADDRESS.City,LIBRARY.LIBRARYID
from LIBRARY join ADDRESS
on LIBRARY.AddressId = Address.AddressId;

select *from Category
insert into Book values( 'De veghe in lanul de secara',12,2016,17,'noH')
insert into Book values( 'Fluturi',13,2016,13,'noH')
insert into Book values( 'Proza',14,2011,18,'HCov')
insert into Book values('Portretul lui Dorian Grey',12,2013,18,'noH')
insert into Book values( 'Urzeala tronurilor',12,2017,30,'Hcov')
insert into Book values( 'Numele vantului',12,2017,35,'noH')
insert into Book values( 'Cartea vietii',12,2017,24,'noH')
insert into Book values( 'Chimista',12,2016,33,'noH')

Insert into Author  values (1,'J.D. Salinger','J');
Insert into Author  values (2,'Irina Binder','I');
Insert into Author  values (3,'Mihai Eminescu','M');
Insert into Author  values (4,'Oscar Wilde','O');
Insert into Author  values (5,' George R. R. Martin ','G');
Insert into Author  values (6,'Patrick Rothfuss','P');
Insert into Author  values (7,' Deborah Harkness','D');
Insert into Author  values (8,'  Stephanie Meyer','S');

insert into BookLibrary values(1,700511,1,5)
insert into BookLibrary values(2,700511,2,3)
insert into BookLibrary values(3,700511,3,10)
insert into BookLibrary values(4,700511,4,6)
insert into BookLibrary values(5,700511,5,25)
insert into BookLibrary values(6,700511,6,10)
insert into BookLibrary values(7,700511,7,4)
insert into BookLibrary values(8,700511,8,2)

select * from BookLibrary

insert into Category values(1,'Clasici')
insert into Category values(2,' Fictiune')
insert into Category values(3,'Clasici')
insert into Category values(4,'Clasici')
insert into Category values(5,' Fantasy')
insert into Category values(6,' Fantasy')
insert into Category values(7,' Fantasy')
insert into Category values(8,' Crime')

select Book.[TITLE] , Author.[FirstName],Book.[YEAR], Category.Name,Book.Price, BOOK.HardCover,BookLibrary.Quantity
from Book 
inner join [Author] on Book.BookId = Author.AuthorId
inner join [Category] on  Book.BOOKID = Category.CategoryId
inner join [BookLibrary] on Book.BOOKID  = BookLibrary.BookId


--G.A


insert into Book values( 'Baltagul',12,2014,17,'noH')
insert into Book values( 'Harry Potter',13,2017,13,'noH')
insert into Book values('Puterea armelor',14,2017,18,'noH')
insert into Book values( 'Fluturi',15,2016,30,'noH')
insert into Book values( 'Proza',16,2011,35,'Hcov')


Insert into Author  values (9,' Mihail Sadoveanu','Ms');
Insert into Author  values (10,'J. K. Rowling','JK');
Insert into Author  values (11,'Joe Abercrombie','J');
Insert into Author  values (12,'Irina Binder','I');
Insert into Author  values (13,'Mihai Eminescu ','M');

insert into BookLibrary values(9,700512,9,5)
insert into BookLibrary values(10,700512,10,8)
insert into BookLibrary values(11,700512,11,4)
insert into BookLibrary values(12,700512,12,14)
insert into BookLibrary values(13,700512,13,7)



insert into Category values(9,'Clasici')
insert into Category values(10,' Aventura')
insert into Category values(11,' Aventura')
insert into Category values(12,'Fictiune')
insert into Category values(13,'Clasici')

select Book.[TITLE] , Author.[FirstName],Book.[YEAR], Category.Name,Book.Price, BOOK.HardCover,BookLibrary.Quantity
from Book 
inner join [Author] on Book.BookId = Author.AuthorId
inner join [Category] on  Book.BOOKID = Category.CategoryId
inner join [BookLibrary] on Book.BOOKID  = BookLibrary.BookId


select * from Address
Insert into  Member
values(1,' Daniel Ionescu', 'D',40194,'M', 0728406394,'daniel.popescu@gmail.com','Strada Pacurari 4B')
Insert into  Member
values(2,' Daniel Ionescu', 'D',23043 ,'M', 0728406394,'daniel.popescu@gmail.com','Strada Pacurari 4B')
Insert into  Member
values(3,' Mihai Popescu', 'M', 40329  ,'M',  0749281504,'mihai.popescu@yahoo.com ','Bulevardul Independentei 2')

insert into Address values ('Strada Pacurari 4B','4', 12,'5',1, 2, 12, 'Iasi', 500, 'Ro', null);

insert into Address values ('Bulevardul Independentei 2','2', 12,'5',1, 1, 5, 'Iasi', 500, 'Ro', null);


select MEMBER.FIRSTNAME , Address.AddressId, ADDRESS.[Building name],ADDRESS.[Floor], ADDRESS.[Apartment number], Address.City,
MEMBER.PHONENUMBER, MEMBER.EMAILADDRESS, MEMBER.PERMISNUMBER
from MEMBER
inner join [Address] on Member.AddressId = Address.AddressId

select *from  book
select * from Request
insert into Request values
(12,' Daniel Ionescu',2,default,700511)
,(13,'Daniel Ionescu',6,default,700511)
,(14,'Daniel Ionescu',8,default,700511)
insert into Request values
(15,' Mihai Popescu',5,default,700512)
,(16,' Mihai Popescu',8,default,700512)
insert into Request values
(17,'  Daniel Ionescu',11,default,700511)
,(18,' Daniel Ionescu ',9,default,700511)

select Book.TITLE, REQUEST.CREATEDDATE
from Book
inner join REQUEST on Book.BOOKID = REQUEST.BOOKID 
