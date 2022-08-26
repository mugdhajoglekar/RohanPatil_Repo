-- ASSIGNMENT 1-

-- create 'student_db' database
-- create following tables in database with proper data types
-- student: id (PK), name, address, phone, email, age, schoolId (FK)
-- school: id (PK), name, address, principal, phone
-- create relationship as shown in the table schema
-- add some dummy data

-- SOLUTION-
create database student_db 
use student_db;

create table school (id int primary key, name varchar(20), 
address varchar(50), principal varchar(20), 
phone varchar(11) check (phone like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'));

create table student (id int primary key, name varchar(20), 
address varchar(50), 
phone varchar(11) check (phone like 
'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
email varchar(20), age int, 
schoolId int foreign key references school(id)); 

insert into school (id, name, address, principal, phone) values 
(1, 'PBM', 'Near Bhavani tek', 'B. S. Dhangar', '1234567890');
(2, 'RCP', 'Near Shirpur Market', 'D. S. Rajput', '0987654321'),
(3, 'Phule', 'Near Police Station', 'R. B. Patil', '2001120356');

select * from school;

insert into student (id, name, address, phone, email, age, schoolId) values 
(101, 'Rohan', 'Marathe Galli', '8788720924', 'patil101@gmail.com', 14, 2),
(102, 'Yashodhan', 'At post Varshi', '9341580921', 'yasho@gmail.com', 8, 1), 
(103, 'Raju', 'At post Manjrod', '4523875093', 'raju@gmail.com', 13, 3);

select * from student;






