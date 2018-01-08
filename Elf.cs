using System;

namespace Task1
{
    public abstract class Elf : Helper
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Height { get; set; }

        public virtual void ElfInfo()
        {
            base.GetInfo();
            Console.WriteLine("Santa really needs those guys!");
        }

        public Elf(string firstname, string lastname, int age, int height)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Height = height;
            About = "Elf";
        }

        

    }
}