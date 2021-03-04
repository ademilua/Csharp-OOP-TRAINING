using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TRAINING
{
    public class MovieActor : Actor, IDancer
    {
        public MovieActor(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public override void Act()
        {
            Console.WriteLine("Hi my name is {0}. I'm a movie actor.", this.FullName);
        }


        // As we can saw from the diagram, this class needs an interface IDANCER for this movie actor object be able to dance
        //Here we need to override the abstract class.

        public override void Dance()
        {
           Console.WriteLine("I can also dance to music from music actors.");
        }
    }
}
