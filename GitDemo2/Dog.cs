using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo2
{
    public class Dog
    {
        public string DogFood { get; set; }
        public Dog()
        {
            DogFood = "Purina Dog Chow";
        }

    
        public virtual void Bark()
        {
            Console.Write("Generic bark");
        }
    }
}
