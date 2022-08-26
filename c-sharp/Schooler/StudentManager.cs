using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schooler
{
    public class StudentManager
    {
        private List<SchoolMember> _students;

        public StudentManager()
        {
            _students = new List<SchoolMember>();
        }

        public void AddStudent(SchoolMember student)
        {
            _students.Add(student);
        }

        public List<SchoolMember> GetStudents()
        {
            return _students;
        }
    }
}
