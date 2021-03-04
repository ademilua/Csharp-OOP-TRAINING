using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TRAINING
{
    /* 
      This is an abstract class
      Accoding to our App digram this class will unify two related classes
      The related two classes are concrete class.
    */
    public abstract class Actor
    {
        // These are fields and they start with an underscore.
        // Best practice is to make the field private, then we can use
        // property to expose them.
        private string _firstName;
        private string _lastName;

        // This is a property
        // The name in convention is for property to start in capital letter
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this._firstName, this._lastName);
            }
        }
        // create the constructor
        // The fields will be set in the constructor 

        public Actor(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        // create an abstract method that the children classes can overide
        // Abstract method will only have signature without implementation
        // An abstract method in an abstract class means the method can be overriden.
        // An we leave the implementation of the abstract method to the concrete class to implement it.
        // Because implementing it here will not be specific to each concrete class that inherits the abstract class 
        //In conclusion abstract reserve keyword means it has no definition of itself and we must overide it to use the method.
        public abstract void Act();

        // We can also have a method with the virtual key word
        // I will come back to this method.
        //public virtual void Act()
        //{
        // Console.WriteLine(String.Format("Hi my name is {0}. I am an actor", this.FullName));
        //}

        public abstract void Dance();
    }
}
