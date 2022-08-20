namespace mediator_design_method
{
    public abstract class CourseMember
    {
        protected Mediator Mediator;
        public CourseMember(Mediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}
