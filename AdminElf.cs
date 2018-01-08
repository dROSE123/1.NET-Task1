using System;

namespace Task1
{
    public class AdminElf : ITElf
    {
        public string SomethingJustForAdmin { get; set; }
        public AdminElf(string firstname, string lastname, int age, int height, string favlang, string adm) : base(firstname, lastname, age, height, favlang)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Height = height;
            FavLang = favlang;
            SomethingJustForAdmin = adm;
            About = "Admin Elf";
        }

        public override double Weight()
        {
            return Height / Age + 2 * Age + 1; //nu e cea mai corecta formula xdd
        }
    }
}