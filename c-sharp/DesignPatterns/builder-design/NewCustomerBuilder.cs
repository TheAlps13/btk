namespace builder_design
{
    public class NewCustomerBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.Id = 1;
            model.Name = "Beer";
            model.CategoryName = "Beverages";
            model.UnitPrice = 35;
        }

        public override void GetProductData()
        {
            model.DiscountedPrice = model.UnitPrice * (decimal)0.90;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }
    }
}
