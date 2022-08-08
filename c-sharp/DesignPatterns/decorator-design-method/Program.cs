using System;

namespace decorator_design_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalCar personalCar = new PersonalCar
            {
                Brand = "Toyota",
                Model = "CRV",
                HirePrice = 5000
            };
            Console.WriteLine($"Personal car hiring price: {personalCar.HirePrice}");
            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            Console.WriteLine($"Special offer: {specialOffer.HirePrice}");
        }
    }

    public abstract class CarBase
    {
        public abstract string Brand { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }

    public class PersonalCar : CarBase
    {
        public override string Brand { get; set; }
        public override string Model { get;set; }
        public override decimal HirePrice { get; set; }
    }

    public abstract class CarDecoratorBase : CarBase
    {
        protected CarBase _carBase;
        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }

    public class SpecialOffer : CarDecoratorBase
    {
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            this.HirePrice = base._carBase.HirePrice - 300;
        }

        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }
}
