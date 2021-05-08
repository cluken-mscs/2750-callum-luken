using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Assignment
    {
        public Assignment (int id, string assign, string description, short maxPoints, DateTime dueDate, AssignmentTypesEnum type, Section section)
        {
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
            this.Id = id;
            this.Assign = assign;
            this.Description = description;
            this.MaxPoints = maxPoints;
            this.DueDate = dueDate;
            this.Type = type;
            this.Section = section;
            Section.Assignments.Add(this);
        }
        public AssignmentGrade FindAssignmentGrade(int id)
        {
            AssignmentGrade foundAssignmentGrade = null;
            foreach (AssignmentGrade a in this.AssignmentGrades)
            {
                if (a.Enrollment.Student.Id == id)
                {
                    foundAssignmentGrade = a;
                    break;
                }
            }
            return foundAssignmentGrade;
        }
    }
}
