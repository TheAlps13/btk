using System;

namespace builder_design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDirector director = new ProductDirector();
            NewCustomerBuilder builder = new NewCustomerBuilder();
            director.GenerateProduct(builder);

            ProductViewModel model = builder.GetModel();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.Name);
            Console.WriteLine(model.IsDiscounted);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.UnitPrice);
        }
    }
}
