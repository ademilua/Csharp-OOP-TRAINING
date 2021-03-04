using System;

namespace OOP_TRAINING
{
    // 
    public class WebDeveloper : Developer, IDancer, ITeacher
    {
        public WebDeveloper(string firstName, string lastName, string devLanguage): base (firstName, lastName, devLanguage)
        {

        }
        public void Dance()
        {
            Console.WriteLine("My name is {0}.I can dance", this.FullName);
        }

        public void Teach()
        {
            Console.WriteLine("Hi my name is {0}. I also teach {1} courses", this.FullName, this.DevLanguage);
        }
        protected override void ChosenDevLanguage()
        {
            Console.WriteLine("Hi my name is {0}. I use {1} as my dev language", this.FullName, this.DevLanguage);
        }
    }
    
}
