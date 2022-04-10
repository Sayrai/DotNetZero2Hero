namespace Oop
{
    using System;

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            Describe();
        }
    }
}
