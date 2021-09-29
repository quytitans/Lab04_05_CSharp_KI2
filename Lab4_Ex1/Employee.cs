using System;

namespace Lab4_Ex1
{
    public abstract class Employee:Person
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public double salary { get; set; }
        public DateTime dateHired { get; set; }
        public override string ToString()
        {
            return $"{"Employee",10} {"|",10} {name,15} {"|",10} {email,30} {"|",10}";
        }

        public abstract double CalculateBonus();
        public abstract void CalculateVacation(int a,string b);
    }
}