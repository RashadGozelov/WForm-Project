create database Library 

create table Users(
Id int primary key identity,
Name nvarchar(100) not null,
Surname nvarchar(100),
Email nvarchar(255) unique not null,
[Password] nvarchar(255) not null,
[Level] bit default 0 not null,
[Status] bit default 0 not null,
Deleted bit default 0 not null,
)

create table Customers(
Id int primary key identity,
Name nvarchar(100) not null,
Surname nvarchar(100),
IdCard nvarchar(100) unique
)

create table Orders(
Id int primary key identity,
GiveDate date,
ReturnDate date,
RealTime date,
UsersId int references Users(Id),
Customers int references Customers(Id)
)

create table Genres(
Id int primary key identity,
Name nvarchar(100) not null
)

create table Books(
Id int primary key identity,
Name nvarchar(100) not null,
Price decimal,
[Count] int,
GenresId int references Genres(Id)
)

create table OrderBook(
Id int primary key identity,
BooksId int references Books(Id),
OrdersId int references Orders(Id)
)



