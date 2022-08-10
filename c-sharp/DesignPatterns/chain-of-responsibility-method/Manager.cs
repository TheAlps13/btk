using System;

namespace chain_of_responsibility_method
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount < 1000)
                Console.WriteLine("Expense handled by manager");
            else if (Successor != null)
                Successor.HandleExpense(expense);
        }
    }
}
