create view view_marks
 as
 select * from marks;


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
