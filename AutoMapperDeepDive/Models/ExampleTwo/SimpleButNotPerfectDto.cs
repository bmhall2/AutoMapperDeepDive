namespace AutoMapperDeepDive.Models.ExampleTwo
{
    public class SimpleButNotPerfectDto
    {
        public int PrimaryKey { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public string GetKeyAndName()
        {
            return $"{PrimaryKey}-{Name}";
        }
    }
}
