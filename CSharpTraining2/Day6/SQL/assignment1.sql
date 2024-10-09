Create table [Courses](
name_stud varchar(50) not null,
id_stud int primary key identity, 
course_name varchar(50) not null,
course_fee int )

insert into [Courses] (name_stud, course_name, course_fee) values
('Gouri', 'Datascience', 1200),
('Ann', 'Webdevelopment', 1000),
('Ram', 'Machine learning', 750),
('Sam', 'Datascience', 1200),
('Mary', 'Webdevelopment', 1000),
('Alex', 'Webdevelopment', 1000),
('Riya', 'Machine learning', 750);

--Select count(id_stud) AS Total_students_in_Datascience from Courses where course_name = 'Datascience';
--Select count(id_stud) AS Total_students_in_Webdevelopment from Courses where course_name = 'Webdevelopment';
--Select count(id_stud) AS Total_students_in_MachineLearning from Courses where course_name = 'Machine learning';
Select course_name, count(id_stud) AS total_students from Courses group by course_name;

--Select sum(course_fee) AS Total_fees_of_Datascience from Courses where course_name = 'Datascience';
--Select sum(course_fee) AS Total_fees_of_Webdevelopment from Courses where course_name = 'Webdevelopment';
--Select sum(course_fee) AS Total_fees_of_Machinelearning from Courses where course_name = 'Machine learning';
Select course_name, sum(course_fee) AS total_fees_collected from courses group by course_name;

Select course_name, count(id_stud) AS number_of_students_enrolled from Courses group by course_name 
having count(id_stud) = (
Select max(count(id_stud)) from Courses group by course_name);
