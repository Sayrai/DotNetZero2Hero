namespace Oop
{
    using System;

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is a circle");
            Describe();
        }
    }
}
