using System;

namespace Task1
{
    public class MechanicElf : Elf
    {
        public int Key { get; set; }

        public int IV { get; set; }


        public MechanicElf(string firstname, string lastname, int age, int height, int key, int iv) : base(firstname, lastname, age, height)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Height = height;
            Key = key;
            IV = iv;
        }

        public virtual void ItsEquipped()
        {
            if (Key * IV > 62)
            {
                if (IV % 2 == 0)
                {
                    Console.WriteLine("Sania a fost incarcata cu succes!");
                }
                else
                {
                    Console.WriteLine("Saniei ii lipsesc 10 cadouri!");
                }
            }
            else
            {
                Console.WriteLine("Sania e goala!");
            }

        }

        public override double Weight()
        {
            throw new NotImplementedException();
            // nobody cares about their weight
        }
    }
}