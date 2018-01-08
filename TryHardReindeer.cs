using System;

namespace Task1
{
    public class TryHardReindeer : Reindeer
    {
        public int HoursToWork { get; set; }
       public TryHardReindeer(string name, int age, int nrwings, int hours) : base(name, age, nrwings)
        {
            Name = name;
            Age = Age;
            NrWings = nrwings;
            HoursToWork = hours;
            About = "TryHard Reindeer";
        }

        public override double Weight()
        {
            if (Age < 10)
            {
                return Age * 7;
            }
            else
            {
                return Age * 5;
            }
        }
    }
}