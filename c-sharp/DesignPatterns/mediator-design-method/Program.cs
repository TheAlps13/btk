namespace mediator_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Teacher teacher = new Teacher(mediator) { Name = "Alper" };
            Student student1 = new Student(mediator) { Name = "Mahmut" };
            Student student2 = new Student(mediator) { Name = "Kemal" };
            Student student3 = new Student(mediator) { Name = "Zuleyha" };
            Student student4 = new Student(mediator) { Name = "Jonathan" };
            Student student5 = new Student(mediator) { Name = "Kamil" };
            Student student6 = new Student(mediator) { Name = "Kevin" };

            //teacher.SendNewImageUrl("Cute dog pics");
            student3.SendQuestion("Is earth flat ?");
            teacher.AnswerQuestion(student3, "Yes");
        }
    }
}
