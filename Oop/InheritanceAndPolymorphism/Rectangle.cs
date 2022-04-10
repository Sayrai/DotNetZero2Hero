namespace Oop
{
    using System;

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Starting to draw a rectangle");
            Describe();
        }
    }
}
