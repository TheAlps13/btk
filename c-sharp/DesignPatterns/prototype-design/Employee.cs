namespace prototype_design
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
