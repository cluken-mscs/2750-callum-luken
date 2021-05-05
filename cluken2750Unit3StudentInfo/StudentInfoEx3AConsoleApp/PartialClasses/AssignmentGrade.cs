using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class AssignmentGrade
    {
        public AssignmentGrade (int id, short points, DateTime dateCompleted, Enrollment enrollment, Assignment assignment)
        {
            this.Id = id;
            this.Points = points;
            this.DateCompleted = dateCompleted;
            this.Assignment = assignment;
            Assignment.AssignmentGrades.Add(this);
            this.Enrollment = enrollment;
            Enrollment.AssignmentGrades.Add(this);
        }
    }
}
