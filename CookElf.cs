using System;

namespace Task1
{
    public class CookElf : CreativeElf
    {
        public CookElf(string fristname, string lastname, int age, int height, string favtool) : base(fristname, lastname, age, height, favtool)
        {
            FirstName = fristname;
            LastName = lastname;
            Age = age;
            Height = height;
            FavTool = favtool;
            About = "Cook Elf";
        }

        public override double Weight()
        {
            return Height / Age + 2 * Age + 1; //nu e cea mai corecta formula xdd 
        }

        public string Food1 { get; set; }
        public string Food2 { get; set; }
        public string Food3 { get; set; }

        public void FoodtList (string food1, string food2, string food3)
        {
            Food1 = food1;
            Food2 = food2;
            Food3 = food3;
        }

        public string GetFood(int n)
        {
            if (n == 0)
            {
                return Food1;
            }
            else if (n == 1)
            {
                return Food2;
            }
            else 
            {
                return Food3;
            }

        }
    }
}