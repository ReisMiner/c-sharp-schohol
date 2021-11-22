using System;
using System.Collections.Generic;

namespace A_HZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            //hier komposition und nicht vererbung weil man nicht speziell für eine firma eine klasse machen muss
            //wenn diese nicht wirklich mehr macht
            
            Company company = new Company("Semens");
            //ein CS ist allerdings ein angestellter, darum braucht er die methoden der Employee klasse, also Vererbung
            ComputerScientist csStudent = new ComputerScientist("Peter Meier", 17);
            KV kvStift = new KV("Helene Fischer", 17);
            csStudent.Departement = Departement.FIRMWARE;
            csStudent.CurrentProject = "SE432";
            company.Employees.Add(csStudent);
            company.Employees.Add(kvStift);
            
            foreach (var employee in company.Employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("Workday ending. Peter is going to sleep!");
            csStudent.DoSleep(3600*8);
            
            /*
             * Private -> nicht vererbt, nur für die eigene klasse
             * Protected -> subklassen zugreifbar
             * internal -> zugreifbar im selben namespace
             * public -> alles kann zugreifen
             */
            
            /*
             * interfaces implementieren einen spezifischen bereich einer klasse.
             * Man hat dann nur auf diesen Teil zugriff.
             */
            //DEMONSTRATION
            List<IWork> workerList = new List<IWork>();
            workerList.Add(csStudent);
            workerList.Add(kvStift);

            foreach (var worker in workerList)
            {
                Console.WriteLine(worker.DoWork());
                // does not work cuz interface
                // Console.WriteLine(worker.DoSleep());
            }
        }
    }
}