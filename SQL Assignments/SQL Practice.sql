 Creating an SQL table 

create table Employee (id int primary key identity(1,1), name varchar(20), 
department varchar(20), tech varchar(20)); 

-- Inserting values in table 

insert into Employee (name, department, tech) 
values ('Rohan', 'Dev', 'Node'), ('Yasho', 'Testing', 'Jira'), 
('Raj', 'Dev', 'Salesforce'), 
('Sanket', 'Marketing', 'Excel'), 
('Suyog', 'HR', 'MS Office'); 

-- Reading table data 
select * from Employee;

-- Updating values

update Employee set name='Yashodhan' where id=2; 
select * from Employee; 
--





