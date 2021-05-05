using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Section
    {
        public Section(int id, short capacity, Course course, Term term)
        {
            this.Enrollments = new HashSet<Enrollment>();
            this.Assignments = new HashSet<Assignment>();
            this.Id = id;
            this.Capacity = capacity;
            this.Term = term;
            Term.Sections.Add(this);
            this.Course = course;
            Course.Sections.Add(this);
        }
        public Enrollment FindEnrollment(int studentId)
        {
            Enrollment foundEnrollment = null;
            foreach (Enrollment e in this.Enrollments)
            {
                if (e.Student.Id == studentId)
                {
                    foundEnrollment = e;
                    break;
                }
            }
            return foundEnrollment;
        }
        public Assignment FindAssignment(int id)
        {
            Assignment foundAssignment = null;
            foreach (Assignment a in this.Assignments)
            {
                if (a.Id == Id)
                {
                    foundAssignment = a;
                    break;
                }
            }
            return foundAssignment;
        }
        public Assignment FindAssignment(string assign)
        {
            Assignment foundAssignment = null;
            foreach (Assignment a in this.Assignments)
            {
                if (a.Assign == assign)
                {
                    foundAssignment = a;
                    break;
                }
            }
            return foundAssignment;
        }
    }
}
