using System;

namespace facade_design_method
{
    public class CustomerManager
    {
        CrossCuttingConcernsFacade _concernsFacade;
        public CustomerManager()
        {
            _concernsFacade = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concernsFacade.Authorizer.CheckUser();
            _concernsFacade.Logger.Log();
            _concernsFacade.Cacher.Cache();
            _concernsFacade.Validator.Validate();
            Console.WriteLine("Saved");
        }
    }

}
