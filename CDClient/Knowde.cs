using System.Collections.Generic;

namespace CDClient
{
    public abstract class Knowde
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public int Mastery { get; set; }
        public void incPriority()
        {
            this.Priority = (this.Priority % 3) + 1;
        }
        public void decPriority()
        {
            int tmp = this.Priority;
            if (tmp > 0)
            {
                this.Priority--;
            }
        }
        public void incMastery()
        {
            int tmp = this.Mastery + 10;
            if (0 <= tmp && tmp <= 100)
            {
                this.Mastery = tmp;
            }
        }
        public void decMastery()
        {
            int tmp = this.Mastery - 10;
            if (0 <= tmp && tmp <= 100)
            {
                this.Mastery = tmp;
            }
        }
    }
}