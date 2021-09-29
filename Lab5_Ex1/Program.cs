using System;
using Lab5_Ex1.Customer;
using Lab5_Ex1.Order;

namespace Lab5_Ex1
{
    namespace Customer
    {
        class Cust_details
        {
            public string strName;
            public void getName()
            {
                Console.WriteLine("Enter your name :");
                strName = Console.ReadLine();
            }
        }
    }
    
    namespace Order
    {
        class Grocery
        {
            public void Ord_grocery()
            {
                Cust_details objCust1 = new Cust_details();
                objCust1.getName();
                Console.WriteLine("Hello {0}", objCust1.strName);
                Console.WriteLine("You have ordered grocery");
            }
        }
        class Bakery
        {
            public void Ord_bakery()
            {
                Cust_details objCust2 = new Cust_details();
                objCust2.getName();
                Console.WriteLine("Hello {0}", objCust2.strName);
                Console.WriteLine("You have ordered bakery");
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("What would you like to order? 1-Grocery Items, 2- Bakery Items");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Grocery objGrocery = new Grocery();
                objGrocery.Ord_grocery();
            }
            else
            {
                if (choice == "2")
                {
                    Bakery objBakery = new Bakery();
                    objBakery.Ord_bakery();
                }
                else
                {
                    Console.WriteLine("Enter either 1 or 2");
                }
            }
            Console.ReadLine();
        }
    }
}