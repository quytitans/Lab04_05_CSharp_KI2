using System;

namespace Lab4_Ex1
{
    public class Faculty : Employee
    {
        public string officeHours { get; set; }
        public string rank { get; set; }
        public override string ToString()
        {
            return $"{"Faculty",10} {"|",10} {name,15} {"|",10} {email,30} {"|",10}";
        }

        public override double CalculateBonus()
        {
            return 1000 + 0.05 * salary;
        }

        public override void CalculateVacation(int a, string b)
        {
            if (a >=3)
            {
                Console.WriteLine("5 weeks");
            }
            else if (b.Equals("Senior Lecturer"))
            {
                Console.WriteLine("6 weeks");
            }
            else
            {
                Console.WriteLine("4 weeks");
            }
        }
    }
}