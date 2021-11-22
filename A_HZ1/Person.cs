using System;
using System.Threading;

namespace A_HZ1
{
    public class Person: ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void DoSleep(int length)
        {
            Thread.Sleep(length);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}