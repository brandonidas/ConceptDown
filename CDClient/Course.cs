namespace CDClient
{
    public class Course
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Summary { get; set; }

        public Topic[] Topics { get; set; }

    }
}
