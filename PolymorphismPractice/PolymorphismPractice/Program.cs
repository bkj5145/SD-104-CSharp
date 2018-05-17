using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Giraffe giraffe = new Giraffe();
            giraffe.Walk();

            Console.WriteLine();

            Elephant elephant = new Elephant();
            elephant.Walk();

            Console.WriteLine();

            Parrot parrot = new Parrot();
            parrot.Walk();

            Console.WriteLine();

            Cat cat = new Cat();
            cat.Walk();

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
