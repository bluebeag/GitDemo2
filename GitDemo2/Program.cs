using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Git!");
            Console.WriteLine("Hello Again Git!");
            Dog dog = new Corgi("Acana Pasture Blend");
            Console.WriteLine("My dog is: " + dog.GetType().Name + ". " + "Dog food is: " + dog.DogFood + ". Bark is: " + dog.Bark());
            Console.ReadKey();
        }
    }
}
