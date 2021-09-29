using System;

namespace Lab4_Ex1
{
    public class Staff:Employee
    {
        public string title { get; set; }
        
        public override string ToString()
        {
            return $"{"Staff",10} {"|",10} {name,15} {"|",10} {email,30} {"|",10}";
        }

        public override double CalculateBonus()
        {
            return 0.06 * salary;
        }

        public override void CalculateVacation(int a, string b)
        {
            if (a>=5)
            {
                Console.WriteLine("4 weeks");
            }
            else
            {
                Console.WriteLine("3 weeks");
            }
        }
    }
}