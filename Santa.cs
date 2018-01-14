using System;

namespace Task1
{
    public class Santa : iCharacter
    {
        public int Age { get; set; }
        public string HairColor { get; set; }
        public string Name { get; set; }

        public int Weight { get; set; }

        public Santa (string name, string haircolor, int age, int weight)
        {
            Name = name;
            HairColor = haircolor;
            Age = age;
            Weight = weight;
        }

        public virtual void LetsRide(int nr, int power)
        {
            if (power < 50)
            {
                Console.WriteLine("Sania nu a pornit!");
            }
            else
            {
                if((Weight * nr + power % 10) / 2 > 50)
                {
                    Console.WriteLine("Sania a pornit! :)");
                }
            }
        }
    }


}