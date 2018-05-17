using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    abstract class Animal
    {
        public  string name;
        public  int numberOfLegs;

        public abstract void Walk();
    }

    class Giraffe : Animal
    {


        public Giraffe()
        {
            this.name = "Jimmy";
            this.numberOfLegs = 4;
        }
        

        public override void Walk()
        {
            Console.WriteLine("Hello I am a Giraffe!!!");
        }
    }

    class Elephant : Animal
    {


        public Elephant()
        {
            this.name = "Brian the Elephant";
            this.numberOfLegs = 4;
        }

     
        //This is a comment
        public override void Walk()
        {
            Console.WriteLine("Hello I am a Elephant!!!");
        }
    }

    class Parrot : Animal
    {


        public Parrot()
        {
            this.name = "Poly";
            this.numberOfLegs = 2;
        }

        public override void Walk()
        {
            Console.WriteLine("Hello I am a Parrot!!!");
        }


    }

    class Cat : Animal
    {


        public  Cat()
        {
            this.name = "Brian";
            this.numberOfLegs = 4;
        }

        public override void Walk()
        {
            Console.WriteLine("Hello I am a Cat!!!");
        }
    }

}