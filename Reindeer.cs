using System;

namespace Task1
{
    public abstract class Reindeer : Helper
    {
        public int NrWings { get; set; }
        protected Reindeer(string name, int age, int nrwings)
        {
            About = "Reindeer";
            Name = name;
            Age = age;
            NrWings = nrwings;

        }

        public virtual void ReindeerInfo()
        {
            base.GetInfo();
            Console.WriteLine("They are transporting the gifts");
        }
    }
}