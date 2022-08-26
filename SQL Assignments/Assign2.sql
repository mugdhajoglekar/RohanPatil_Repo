-- ASSIGNMENT 2- 

-- create 'product_db' databse
-- create following tables
-- categories: id (PK), title, description
-- products: id (PK), title, price, description, category (FK), company
-- orders: id (PK), total, date
-- order_details: id (PK), orderId (FK), productId (FK), quantity, price, totalPrice, discount
-- create relationship as shown in the table schema
-- add some dummy data

-- SOLUTION-

create database product_db;
use product_db;

create table categories ( id int primary key, title varchar(20),
description varchar(50));

create table products (
    id int primary key, 
    title varchar(20), price int,
    description varchar(50), 
    company varchar(20), 
    category int foreign key references categories (id)
    );

create table orders (
    id int primary key,
     total int, 
     date varchar(30)
     );

create table order_details (
    id int primary key,
    orderId int foreign key references orders (id),
    productId int foreign key references products (id),
    quantity int,
    price int,
    totalPrice int,
    discount int
) 

insert into categories values
    (1, 'Health', 'Pharma & Nutrition based products'),
    (2, 'Tech', 'Eletronic machines'),
    (3, 'Kitchen', 'Appliances and Utensils'),
    (4, 'Lifestyle', 'Fashion and Accesories');

insert into products values
(11, 'Iphone', 1000, 'Latest smartphone by Apple', 'Apple', 2),
(12, 'Microwave', 300, 'Needed for cooking', 'Prestige', 3),
(13, 'Sweatshirt', 50, 'Full sleeves in gray colour', 'H&M', 4),
(14, 'Sports shoes', 100, 'White mesh shoes', 'Asian', 4),
(15, 'Galaxy S20', 800, 'Android smartphone', 'Samsung', 2),
(16, 'Whey Protein', 150, '80% concentrate', 'AsItIs', 1),
(17, 'Regrigerator', 500, 'Single door refrigerator', 'LG', 2); 

insert into orders values
(101, 850, '12/03/2021'),
(102, 450, '8/6/2022'),
(103, 2400, '24/4/2022'),
(104, 540, '10/12/2020');

insert into order_details values
(51, 102, 11, 1, 1000, (1000*1)-(1000*1)*15/100, 15),
(52, 104, 16, 4, 150, (150*4)-(150*4)*25/100, 25),
(53, 103, 17, 8, 500, (500*8)-(500*8)*40/100, 40),
(54, 101, 12, 6, 300, (300*6)-(300*6)*70/100, 70);














