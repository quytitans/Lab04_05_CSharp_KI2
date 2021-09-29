using System;

namespace Lab4_02
{
    class IndexerExample
    {
        public int[] intList = new int[10];
        public int this[int index]
        {
            get{return intList[index];}
            set{intList[index] = value;}
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i, j = 0;
            IndexerExample indexTest = new IndexerExample();
            for (i = 1; i < 10; i += 2)
            {
                indexTest[j] = i;
                j++;
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("indexTest[{0}] is {1}", i, indexTest[i]);    
            }
            Console.ReadLine();
        }
    }
}