using System;

namespace Task1
{
    public abstract class Helper :iCharacter
    {

        public string About { get; set;}
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void GetInfo() 
        {
            Console.WriteLine($"This is a {About}");
        }

        public abstract double Weight();
    }
}