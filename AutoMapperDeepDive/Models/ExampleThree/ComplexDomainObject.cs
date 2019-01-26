namespace AutoMapperDeepDive.Models.ExampleThree
{
    public class ComplexDomainObject
    {
        public long Id { get; set; }
        public InnerDomainObject InnerDomainObject { get; set; }
    }

    public class InnerDomainObject
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
