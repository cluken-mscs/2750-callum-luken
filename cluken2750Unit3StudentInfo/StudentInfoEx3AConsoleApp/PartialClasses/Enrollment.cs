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
        public AssignmentGrade FindAssignmentGrade(string id)
        {
            AssignmentGrade foundAssignmentGrade = null;
            foreach (AssignmentGrade g in this.AssignmentGrades)
            {
                if (g.Assignment.Assign == id)
                {
                    foundAssignmentGrade = g;
                    break;
                }
            }
            return foundAssignmentGrade;
        }
        public AssignmentGrade FindAssignmentGrade(int id)
        {
            AssignmentGrade foundAssignmentGrade = null;
            foreach (AssignmentGrade a in this.AssignmentGrades)
            {
                if (a.Assignment.Id == id)
                {
                    foundAssignmentGrade = a;
                    break;
                }
            }
            return foundAssignmentGrade;
        }

        public int CalcTotalPoints()
        {
            int totalPoints = 0;
            foreach (AssignmentGrade g in this.AssignmentGrades)
            {
                totalPoints += g.Points;
            }
            return totalPoints;
        }

        public GradesEnum CalcGrade()
        {
            GradesEnum grade = GradesEnum.Z;
            int maxPoints = this.Section.CalcTotalPoints();
            if (maxPoints > 0)
            {
                int totalPoints = this.CalcTotalPoints();
                double pct = totalPoints * 100 / maxPoints;

                if (pct >= 90.0)
                    grade = GradesEnum.A;
                else if (pct >= 80.0)
                    grade = GradesEnum.B;
                else if (pct >= 70.0)
                    grade = GradesEnum.C;
                else if (pct >= 60.0)
                    grade = GradesEnum.D;
                else
                    grade = GradesEnum.F;
            }
            return grade;
        }

    }
}
