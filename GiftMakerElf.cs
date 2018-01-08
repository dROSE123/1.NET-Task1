using System;
using System.Collections.Generic;

namespace Task1
{
    public class GiftMakerElf : CreativeElf
    {

        public GiftMakerElf(string fristname, string lastname, int age, int height, string favtool) : base(fristname, lastname, age, height, favtool)
        {
            FirstName = fristname;
            LastName = lastname;
            Age = age;
            Height = height;
            FavTool = favtool;
            About = "Gift Maker Elf";
        }

        public override double Weight()
        {
            return Height / Age + 2 * Age + 1; //nu e cea mai corecta formula xdd
        }

        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }

        public string Item4 { get; set; }

        public void GiftList (string item1, string item2, string item3, string item4)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }

        public string GetGift(int n)
        {
            if (n == 0)
            {
                return Item1;
            }
            else if (n == 1)
            {
                return Item2;
            }
            else if (n == 2)
            {
                return Item3;
            }
            else 
            {
                return Item4;
            }

        }

    }
}