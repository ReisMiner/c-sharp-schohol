using System;
using System.Threading;

namespace A_HZ1
{
    public class ComputerScientist : Employee
    {
        public string CurrentProject { get; set; }

        public ComputerScientist(string name, int age) : base(name, age)
        {
            IsDepressed = true;
        }

        public override string ToString()
        {
            return base.ToString() + "\nProject working on: " + CurrentProject;
        }

        public override void DoSleep(int length)
        {
            Thread.Sleep(0);
            Console.WriteLine("Computer Scientists don't sleep!");
        }

        public override string DoWork()
        {
            return $"{new Random().Next(0, 5) * GetMotivation()}% almost no Work done!";
        }
    }
}