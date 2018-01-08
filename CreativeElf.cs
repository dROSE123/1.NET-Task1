using System;
using System.Collections.Generic;

namespace Task1
{
    public abstract class CreativeElf : Elf
    {

        public string FavTool { get; set; }
        public CreativeElf(string fristname, string lastname, int age, int height, string favtool) : base(fristname, lastname, age, height)
        {
            FirstName = fristname;
            LastName = lastname;
            Age = age;
            Height = height;
            FavTool = favtool;
        }

        public virtual void CreativeElfInfo()
        {
            base.GetInfo();
            Console.WriteLine("They are doing the dirty job");
        }

    }
}