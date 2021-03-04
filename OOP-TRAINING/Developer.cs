using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TRAINING
{ 

    // we are going to do the same thing we did with the Actor class.
    public abstract class Developer
    {
        private string _firstName;
        private string _lastName;
        private string _devLanguange;

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}",_firstName, _lastName);
            }
        }

        public string DevLanguage
        {
            get
            {
                return string.Format("{0}",_devLanguange);
            }
        }

        public Developer(string firstName, string lastName, string devLanguage)
        {
            _firstName = firstName;
            _lastName = lastName;
            _devLanguange = devLanguage;

        }

        // developers need to be able to write code
        //We will want our developer to have the posibility of chosen their own dev language to write code.
        // This means the Code we have 1 step of developement process.
        // I change this method from abstract  to just have a void because i will like to call the Code, outside of the children class.
        // e.g in the program.cs file, using the object of a class.
        public void Code()
        {
            ChosenDevLanguage();
        }

        //Therefore, I will make a method call ChosenDevLanguage()
        // the method will be protected here, because we want it to be available within this class and every other
        // class(es) that will inherit from this 

        protected abstract void ChosenDevLanguage();
    }
}
