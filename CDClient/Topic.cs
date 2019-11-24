using System.Collections.Generic;

namespace CDClient
{
    public class Topic
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public int Mastery { get; set; }
        public string Remarks { get; set; }

        public Concept[] Concepts { get; set; }
    }
}