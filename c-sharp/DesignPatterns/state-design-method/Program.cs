using System;

namespace state_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseContext context = new DatabaseContext();
            context.SetState(new ModifiedState());
            context.SaveChanges();
            context.SetState(new DeletedState());
            context.SaveChanges();
        }
    }

    public interface DatabaseState
    {
        public void SaveChanges(DatabaseContext context);
    }

    public class DatabaseContext
    {
        private DatabaseState _state;

        public DatabaseContext()
        {
            _state = new ModifiedState();
        }

        public void SetState(DatabaseState state)
        {
            _state = state;
        }

        public DatabaseState GetState()
        {
            return _state;
        }

        public void SaveChanges()
        {
            _state.SaveChanges(this);
        }
    }

    public class ModifiedState : DatabaseState
    {
        public void SaveChanges(DatabaseContext context)
        {
            Console.WriteLine("Database record modified!");
        }
    }

    public class DeletedState : DatabaseState
    {
        public void SaveChanges(DatabaseContext context)
        {
            Console.WriteLine("Database record deleted!");
        }
    }
}
