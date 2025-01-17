﻿namespace Oop
{
    using System;
    public abstract class Shape
    {
        public string Name { get { return this.GetType().Name; } }
        //Circle, Triangle, Rectangle e.t.c
        protected void Describe() => Console.WriteLine($"This is a {Name} Description");
        public abstract void Draw();
    }
}
