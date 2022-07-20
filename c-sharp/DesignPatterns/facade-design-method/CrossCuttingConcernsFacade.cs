namespace facade_design_method
{
    public class CrossCuttingConcernsFacade
    {
        public ILogger Logger { get; set; }
        public IAuthorizer Authorizer { get; set; }
        public ICacher Cacher { get; set; }
        public IValidate Validator { get; set; }
        public CrossCuttingConcernsFacade()
        {
            Logger = new Logging();
            Authorizer = new Authorize();
            Cacher = new Caching();
            Validator = new Validation();
        }
    }

}
