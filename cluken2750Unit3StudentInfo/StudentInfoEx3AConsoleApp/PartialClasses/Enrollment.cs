using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Enrollment
    {
        public Enrollment (int id, GradeTypesEnum gradeType, GradesEnum grade, Student student, Section section)
        {
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
            this.Id = id;
            this.GradeType = gradeType;
            this.Grade = grade;
            this.Section = section;
            Section.Enrollments.Add(this);
            this.Student = student;
            Student.Enrollments.Add(this);
        }
        public AssignmentGrade FindAssignmentGrade(string assignment)
        {
            AssignmentGrade foundAssignmentGrade = null;
            foreach (AssignmentGrade g in this.AssignmentGrades)
            {
                if (g.Assignment.Id.ToString() == assignment.ToString())
                {
                    foundAssignmentGrade = g;
                    break;
                }
            }
            return foundAssignmentGrade;
        }
    }
}
