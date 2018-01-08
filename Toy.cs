using System;

namespace Task1
{
    public class Toy : iGift
    {
        public string Lenght { get; set; }
        public string Width { get; set; }
        public Toy(string lenght, string width, string color)
        {
            Lenght = lenght;
            Width = width;
            Color = color;
        }

        public string Color { get ; set ; }
    }
}