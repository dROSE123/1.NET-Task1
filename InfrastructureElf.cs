using System;

namespace Task1
{
    public class InfrastructureElf : ITElf
    {
        public string SomethingJustForInfrastructure { get; set; }
        public InfrastructureElf(string firstname, string lastname, int age, int height, string favlang, string infr) : base(firstname, lastname, age, height, favlang)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Height = height;
            FavLang = favlang;
            SomethingJustForInfrastructure = infr;
            About = "Infrastructure Elf";
        }

        public override double Weight()
        {
            return Height / Age + 2 * Age + 1; //nu e cea mai corecta formula xdd
        }
    }
}