using System;

namespace mediator_design_method
{
    public class Teacher : CourseMember
    {
        public string Name { get; set; }
        public Teacher(Mediator mediator) : base(mediator)
        {
            mediator.Teacher = this;
        }

        public void ReceiveQuestion(Student student, string question)
        {
            Console.WriteLine($"Teacher received a question from {student.Name};\n{question}\n");
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine($"Teacher changed slide : {url}\n");
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(Student student, string answer)
        {
            Console.WriteLine($"Teacher answered question of {student.Name};\n{answer}\n");
            Mediator.SendAnswer(student, answer);
        }
    }
}
