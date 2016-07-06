using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class OrangeTree
    {
        public OrangeTree(int age, int height)
        {
            this.Age = age;
            this.Height = height;
            TreeAlive = true;
            NumOranges = 0;
            OrangesEaten = 0;
        }

        public bool TreeAlive { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public int NumOranges { get; set; }
        public int OrangesEaten { get; set; }

        internal void OneYearPasses()
        {
            this.Age++;
            Height += 2;

            if (Age == 80)
                TreeAlive = false;
        }

        internal void EatOrange(int v)
        {
            NumOranges -= v;
            if (NumOranges < 0)
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!There are 0 oranges available to eat");
        }
    }

}
