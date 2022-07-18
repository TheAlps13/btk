namespace builder_design
{
    public class OldCustomerBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = 10;
            model.IsDiscounted = true;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.Name = "Beer";
            model.CategoryName = "Beverages";
            model.UnitPrice = 35;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }
    }
}
