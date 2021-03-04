using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TRAINING
{
    public class MusicActor : Actor
    {
        public MusicActor(string firstName, string lastName): base(firstName, lastName)
        {

        }
        // This class needs to also implement the act() in the Actor abstract class.
        public override void Act()
        {
            Console.WriteLine("Hi my name is {0}. I'm a music actor.", this.FullName);
        }

        public override void Dance()
        {
            Console.WriteLine("I can dance to music.");
        }
    }
}
