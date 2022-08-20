using System;

namespace mediator_design_method
{
    public class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
            mediator.Students.Add(this);
        }

        public string Name { get; set; }
        public void ReceiveImage(string url)
        {
            Console.WriteLine($"{Name} received image {url}\n");
        }

        public void SendQuestion(string question)
        {
            Mediator.SendQuestion(this, question);
        }
        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine($"{Name} received answer;\n{answer}\n");
        }

    }
}
