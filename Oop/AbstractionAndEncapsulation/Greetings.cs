using System;

namespace Oop
{
    internal class Greetings
    {
        /// <summary>
        ///  Abstraction-Hiding away implementation details
        /// </summary>
        /// <param name="name">name of person to greet</param>
        internal void SayHello(string name)
        {
            if (name == "Sarah")
            {
                Console.WriteLine($"Hello, {name}");
            }
            else
            {
                Console.WriteLine("Oops! Unrecorginsed fellow");
            }
        }


        /*Access modifiers
         * private
         * protected
         * internal
         * protected internal 
         * public
         */
        private class PrivateGreeter
        {

        }
    }
}
