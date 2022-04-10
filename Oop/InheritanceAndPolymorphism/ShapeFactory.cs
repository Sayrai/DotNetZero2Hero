namespace Oop
{
    using System;

    public class ShapeFactory
    {
        public static Shape Create(string name)
        {
            switch (name)
            {
                case nameof(Circle): return new Circle();
                case nameof(Triangle): return new Triangle();
                case nameof(Rectangle): return new Rectangle();
                default: throw new Exception("Invalid shape");
            }
        }
    }
}
