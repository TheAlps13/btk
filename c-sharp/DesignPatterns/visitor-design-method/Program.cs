using System;
using System.Collections.Generic;

namespace visitor_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);

        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public class VisitorBase
    {
        internal void Visit()
        {
            throw new NotImplementedException();
        }
    }
    public class OrganisationalStructure
    {
        public EmployeeBase Employee;

        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }

    public class Manager : EmployeeBase
    {
        public List<EmployeeBase> Subordinates { get; set; } = new List<EmployeeBase>();
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit();

            foreach(var employee in Subordinates)
                employee.Accept(visitor);
        }
        
    }
}
