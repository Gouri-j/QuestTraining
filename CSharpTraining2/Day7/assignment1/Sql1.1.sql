Create table students(
 id bigint primary key identity,
 name varchar(50) not null
 );

 insert into students (name) values
 ('Gouri'),
 ('John'),
 ('Sam');



Create table subjects(
   id bigint primary key identity(100,1),
   name varchar(50) not null unique,
   code VARCHAR(10) not null unique 
);
   
   
 insert into subjects(name, code) values
 ('English', 'ENG101'),
 ('Science', 'SNC102'),
 ('Hindi', 'HIN103');
   
   

Create table exam(
   id bigint primary key identity(200,1),
   name varchar(50) not null,
   min_mark int not null default 40,
   max_mark int not null default 100
);
   
 insert into exam (name, min_mark, max_mark) values
 ('midterm',20,50),
 ('final',40,100);
   
   
   
   
Create table marks(
    id bigint primary key identity,
	mark int not null,
	student_id bigint,
	subject_id bigint,
	exam_id bigint,

	constraint fk_student_id foreign key(student_id) references students(id),
	constraint fk_subject_id foreign key(subject_id) references subjects(id),
	constraint fk_exam_id foreign key (exam_id) references exam(id)
);
   
insert into marks(mark, student_id, subject_id, exam_id) values
(45, 1, 100, 200),
(87, 2, 101, 200), 
(65, 3,100, 201);
 

 create view view_marks
 as
 select * from marks;


 select  marks.id as mark_id,
   marks.mark,
   students.id as student_id,
   students.name as student_name,
   subjects.id as subject_id,
   subjects.name as subject_name,
   exam.id as exam_id,
   exam.name as exam_name
from 
marks inner join students 
on marks.student_id = students.id
inner join subjects 
on marks.subject_id = subjects.id 
inner join exam 
on marks.exam_id = exam.id;



Select students.name as student_name,
  exam.name as exam_name,
  marks.mark
from 
marks left join students
on marks.student_id = students.id
inner join exam
on marks.exam_id = exam.id;



Select students.name as student_name,
       students.id as student_id,
	   exam.name as exam_name,
	   subjects.name as subject_name,
	   marks.mark
from
marks left join students
on marks.student_id = students.id
inner join exam
on marks.exam_id = exam.id
inner join subjects
on marks.subject_id =subjects.id;


select * from view_marks order by mark desc;




create view 
 view_marks_data
 as
 Select students.name as student_name,
       students.id as student_id,
	   exam.name as exam_name,
	   subjects.name as subject_name,
	   marks.mark
from
marks left join students
on marks.student_id = students.id
inner join exam
on marks.exam_id = exam.id
inner join subjects
on marks.subject_id =subjects.id;



select * from view_marks_data order by mark desc;