create table [students](
 [id] int primary key identity,
 [name] varchar(50) not null, 
 [email] varchar(100) unique not null,
[class] int default 1)

insert into [students] (name, email, class) values
('Gouri', 'gouri@gmail.com', 10),
('Anjali', 'anjali@gamil.com',12);
('John', 'john@gmail.com', 14),
('Michel', 'michel@gmail.com', 20);

 --Select id, name from students where id = 3;
 --Select id, name from students where email = 'gouri@gmail.com'

 --Select id, name, class from students where id > 2 AND id <= 4
