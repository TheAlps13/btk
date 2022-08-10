namespace chain_of_responsibility_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader = new();
            Manager manager = new();
            Ceo ceo = new();

            teamLeader.SetSuccessor(manager);
            manager.SetSuccessor(ceo);

            teamLeader.HandleExpense(new Expense
            {
                Amount = 122,
                Detail = "Some food"
            });
        }
    }
}
