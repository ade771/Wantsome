use[tema2];


Create table Customer
(CustomerId int Primary Key not null,
Nume varchar (50) not null,
Email varchar(50) null
);

Create table Employee
(
EmployeeId int Primary key not null,
Nume varchar(50) not null,
Email varchar(50) null
);

Create table Category
(
CategoryId int Primary key not null,
Nume varchar(50) not null,
EmployeeId int not null
);

Create table Product
(
ProductId int Primary key not null,
Nume varchar(50) not null,
CategoryId int not null,
[Description] varchar(100) null,
Price decimal not null
);

Create table OrderProduct
(OrderId int Primary Key not null,
ProductId int not null,
NumberOfProducts int null
);

Create table [Order]
(
OrderId int Primary Key not null,
Number int null,
[Data] DATE DEFAULT GETDATE(),
CustomerId int not null,
[Status] varchar (10) not null,
TotalPrice decimal null
);
--Alter table Library
--add foreign key(AddressId) references [ADDRESS](AddressId);


Alter table Category
add foreign Key (EmployeeId) references Employee(EmployeeId);

alter table Product
add foreign key (CategoryId) references Category(CategoryId);

alter table OrderProduct
add foreign key (ProductId) references Product(ProductId);

alter table OrderProduct
add foreign key (OrderId) references [Order](OrderId);

alter table [Order]
add foreign key (CustomerId) references Customer(CustomerId);

select*from Employee
select*from Category

insert into Employee values (1, 'Alin', 'alin@gmail.com'), (2, 'Marian', 'marian@gmail.com'), (3, 'Ana' , 'ana@gmail.com')

insert into Category values (1,'Carne', 1), (2, 'Fructe', 2), (3, 'Legume' , 2) , (4, 'Cereale', 3);


--Afisati toate produsele.
insert into Product values 
(1,'CarneDePui',1,'	Pulpe de pui dezosate' , 20),
(2,'Mere',2, 'Mere Golden', 5),
(3,'Castraveti', 3, 'Castravete Fabio', 6),
(4, 'Porumb', 4, 'Fulgi de porumb', 12);

Insert into Product values
(5, 'CarneDePorc', 1, 'Ceafa de porc', 39),
(6, 'Pere', 2, null, 10),
(7, 'Rosii', 3, 'Rosii cherry',  6),
(8, 'Ovaz', 4, 'Fulgi de ovaz', 3);



select* from Product


insert into Customer values
(1, 'Ion', 'ion@wantsome.com'),
(2, 'Alina', 'alina@gmail.com'),
(3, 'Andreea', 'andrea@wantsome.com');
select *from Customer


--Afisati toti clientii care au in continutul email-ului @wantsome.com.
select * from Customer where Email LIKE '%wan%';


-----------------Afisati suma preturilor pentru fiecare categorie in parte.-----
--Pret total pt categoria1
SELECT Sum(Price)
FROM Product
WHERE CategoryId = 1;

--Pret total pt categoria 2
SELECT Sum(Price)
FROM Product
WHERE CategoryId = 2;

--Pret total pt categoria3
SELECT Sum(Price)
FROM Product
WHERE CategoryId = 3;

--Pret total pt categoria 4
SELECT Sum(Price)
FROM Product
WHERE CategoryId = 4;

-----Afisati clientii care au mai mult de 10 comenzi.----

select *from [Order]
insert into [Order] values
(1, 11, default, 1, 'approved',124),
(2, 12, default, 2, 'approved',199),
(3, 2, default, 3, 'approved', 100);


select  Customer.[Nume], [Order].Number
from [Order] 
inner join [Customer] on Customer.CustomerId = [Order].CustomerId
where Number >10

------------Creati un view care va afisa toti clientii si produsele comandate de acestia.----------------

Select * from [Order]
insert into OrderProduct values
(1, 1, 11),
(2, 2, 12),
(3, 3, 2)

