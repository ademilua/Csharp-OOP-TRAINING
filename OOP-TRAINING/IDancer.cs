using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TRAINING
{
    // To make this class an interface, we need to use interface identifier
    // We create an interface class
    /* Now we want to be able to give access to our movieActor and MusicActor to be able to dance
      Question> Why do we have to do the above using an interface? Reason because in c# we can have multiple inheritance through multiple
      classes, we solve this problem using an interface.
    */
    public interface IDancer
    {
        void Dance();
    }
}
