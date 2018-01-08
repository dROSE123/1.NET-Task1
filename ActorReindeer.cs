using System;

namespace Task1
{
    public class ActorReindeer : Reindeer
    {
        public string FavMovie { get; set; }
        protected ActorReindeer(string name, int age, int nrwings, string favmovie) : base(name, age, nrwings)
        {
            Name = name;
            Age = age;
            NrWings = nrwings;
            FavMovie = favmovie;
            About = "Actor Reindeer";
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