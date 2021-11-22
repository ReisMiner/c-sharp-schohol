using System.Collections.Generic;

namespace A_HZ1
{
    public class Company
    {
        
        public string CompanyName { get; set; }
        
        public List<Employee> Employees { get; set; }

        public Company(string companyName)
        {
            CompanyName = companyName;
            Employees = new List<Employee>();
        }
    }
}