using System;

namespace Task1
{
    public abstract class ITElf : Elf
    {
        public string FavLang { get; set; }
        public ITElf(string firstname, string lastname, int age, int height, string favlang) : base(firstname, lastname, age, height)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Height = height;
            FavLang = favlang;
            About = "IT Elfs";
        }
        
        public virtual void ITElfInfo()
        {
            base.GetInfo();
            Console.WriteLine("They are the geek guys");
        }
    }
}