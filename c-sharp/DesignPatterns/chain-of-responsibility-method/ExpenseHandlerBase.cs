namespace chain_of_responsibility_method
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor { get; set; }
        public abstract void HandleExpense(Expense expense);
        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
        }
    }
}
