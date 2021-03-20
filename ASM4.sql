
use master
IF EXISTS (SELECT * FROM sys.databases WHERE name='BookStore')
	DROP DATABASE BookStore
Go



create database BooksManager
go
use BooksManager
go

create table Books
(
	bookID int,
	bookName varchar(50),
	bookPrice float
)

create table Employee
(
	empID char(10),
	empPassword char(15),
	empRole bit
)

Update Books set bookPrice = 125000 where bookID = 106
select * from Books order by bookPrice desc
select  sum(bookPrice) as [Tong] from Books 



INSERT INTO Books VALUES (101,'Harry Potter',250000)
INSERT INTO Books VALUES (102,'The Silence of the Lambs',175000)
INSERT INTO Books VALUES (103,'War and Peace',230000)
INSERT INTO Books VALUES (104,'Lolita',256000)
INSERT INTO Books VALUES (105,'The Adventures of Huckleberry Finn',150000)

INSERT INTO Employee VALUES ('E01','1','1')
INSERT INTO Employee VALUES ('E02','1','0')
INSERT INTO Employee VALUES ('E03','1','0')
INSERT INTO Employee VALUES ('E04','1','0')
INSERT INTO Employee VALUES ('E05','1','0')
