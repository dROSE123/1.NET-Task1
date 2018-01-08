using System;

namespace Task1
{
    public class Candy : iGift
    {
        public string Taste { get; set; }
        public Candy(string taste, string color)
        {
            Taste = taste;
            Color = color;
        }

        public string Color { get ; set ; }
    }
}