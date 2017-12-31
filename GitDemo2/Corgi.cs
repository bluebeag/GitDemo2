using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo2
{
    public class Corgi : Dog
    {
        public Corgi(string dogFood)
        {
            DogFood = dogFood;
        }

        public override void Bark()
        {
            Console.Write("Corgi bark!");
        }
    }
}
