using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public delegate void OnSalaryIncrease(float amount);
    public class Employee
    {
        public event OnSalaryIncrease OnIncreasing;
        public String Name { get; set; }
        public float Salary { get; set; }
        public Employee(String _Name, float _Salary) {Name = _Name ; Salary = _Salary; }
        
        public void Increase(float amount)
        {
            Salary = Salary + amount;
            Notify(amount);
        }
        void Notify(float amounts)
        {
            OnIncreasing.Invoke(amounts);
        }

    }
    public class Company
    {
        public String Name { get; set; }
        public float Budget { get; set; }
        public Company(float _Budget) { Budget = _Budget; }
        public void BudgetDecrease(float amount)
        {
            Budget = Budget - amount;
            Console.WriteLine($"The New Budget is {Budget}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Ahmed = new Employee("Ahmed", 2000);
            Company Galaxy = new Company(5000);
            Ahmed.OnIncreasing += Galaxy.BudgetDecrease;
            Ahmed.Increase(1000);


           

            
            Console.ReadLine();

        }
    }
}
