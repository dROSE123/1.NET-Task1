using System;

namespace Task1
{
    public class MechanicElf : Elf
    {


        public MechanicElf(string firstname, string lastname, int age, int height) : base(firstname, lastname, age, height)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Height = height;
        }

        public virtual void ItsEquipped(int key)
        {
            if (key * 8 > 40)
            {
                if (key % 2 == 0)
                {
                    Console.WriteLine("Sania a fost incarcata cu succes!");
                }
                else
                {
                    Console.WriteLine("Saniei ii lipsesc 5 cadouri!");
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