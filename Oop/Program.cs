using System;

namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.Write("Hello, what's your name? ");
            var name = Console.ReadLine();

            var greeting = new Greetings();
            greeting.SayHello(name);


            //draw a shape
            #endregion
            while (true)
            {
                try
                {
                    Console.Write("Enter the shape to create: (e.g Circle, Triangle or Rectangle): ");
                    string shape = Console.ReadLine();

                    Shape sh = ShapeFactory.Create(shape);
                    sh.Draw();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }


                Console.WriteLine("==============================================");
            }


            Console.ReadLine();
        }

    }
}
