using System;

namespace chain_of_responsibility_method
{
    public class TeamLeader : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if(expense.Amount <= 100)
                Console.WriteLine("Expense handled by team leader");
            else if(Successor != null)
                Successor.HandleExpense(expense);
        }
    }
}
