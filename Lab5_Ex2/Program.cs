using System;

namespace Lab5_Ex2
{
    internal class Program
    {
        public class InvalidInput : ApplicationException
        {
            
            public InvalidInput(string personName,double salary) : base ($"{personName} have salary = {salary} =>> Senior Lecture gets less than 60,000 salary"){}
            
            public InvalidInput(string personName, int bound) : base(($"{personName} have bound = {bound} =>> bonus is more than 10,000")){}
           
        }
        
        public static void Main(string[] args)
        {
            double salary;
            int bonus;
            string personName;
            Console.WriteLine("Enter personName");
            personName = Console.ReadLine();
            Console.WriteLine("Enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
            if (salary<60000)
            {
                throw new InvalidInput(personName,salary);
            }
            Console.WriteLine("Enter bound");
            bonus = Convert.ToInt32(Console.ReadLine());
            if (bonus<10000)
            {
                throw new InvalidInput(personName,bonus);
            }
            Console.WriteLine("salary = {0}, bonus = {1}, personName = {2}", salary,bonus,personName);
        }
    }
}