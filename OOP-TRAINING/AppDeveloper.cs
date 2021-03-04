using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TRAINING
{
    public class AppDeveloper : Developer
    {
        public AppDeveloper(string firstName, string lastName, string devLanguage) : base(firstName, lastName, devLanguage)
        {

        }
        protected override void ChosenDevLanguage()
        {
            Console.WriteLine("Hi my name is {0}. I use {1} as my dev language", this.FullName, this.DevLanguage);
        }
    }
}
