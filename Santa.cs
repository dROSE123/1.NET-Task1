using System;

namespace Task1
{
    public class Santa : iCharacter
    {
        public int Age { get; set; }
        public string HairColor { get; set; }
        public string Name { get; set; }

        public int SecretCod { get; set; }

        public Santa (string name, string haircolor, int age, int secretcod)
        {
            Name = name;
            HairColor = haircolor;
            Age = age;
            SecretCod = secretcod;
        }

        public virtual void LetsRide()
        {
            if (SecretCod > 19)
            {
                Console.WriteLine("Sania a pornit!");
            }
            else
            {
                Console.WriteLine("Sania nu a pornit!");
            }

        }
    }


}