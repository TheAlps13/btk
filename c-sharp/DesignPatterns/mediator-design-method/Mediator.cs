using System.Collections.Generic;

namespace mediator_design_method
{
    public class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public void UpdateImage(string url)
        {
            foreach (Student student in Students)
                student.ReceiveImage(url);
        }

        public void SendQuestion(Student student, string question)
        {
            Teacher.ReceiveQuestion(student, question);
        }

        public void SendAnswer(Student student, string answer)
        {
            student.ReceiveAnswer(answer);
        }
    }
}
