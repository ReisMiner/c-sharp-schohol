using System;

namespace A_HZ1
{
    public class Employee : Person, IWork
    {

        public bool IsDepressed { get; set; }
        public Departement Departement { get; set; }
        
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} - {Departement}\nDepressed: {(IsDepressed ? "Yes" : "No")}";
        }

        public virtual string DoWork()
        {
            return $"{new Random().Next(0, 10) * GetMotivation()}% Work done!";
        }

        public int GetMotivation()
        {
            if (IsDepressed)
            {
                return new Random().Next(0, 10);
            }
            else
            {
                return new Random().Next(80, 100);
            }
        }
    }
}