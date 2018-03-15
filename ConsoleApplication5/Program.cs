using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    class Demo
    {

        public int[] array = new int[6];
        public int i, j, valSearch;
        public void Begin()
        {
            Console.WriteLine("Enter values for array .");
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter value : ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Search()
        {
            Console.WriteLine("\nEnter value to search :");
            valSearch = int.Parse(Console.ReadLine());
            for (j = 0; j < array.Length; j++)
            {
                if (array[j] == valSearch)
                {
                    array[j] = 0;
                }

            }
        }
            public void FinalPrint(){
                Console.WriteLine("New Array after elimination .");
            for (int l = 0; l < array.Length; l++)
            {
                Console.WriteLine("" + array[l]);
            }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Demo call = new Demo();
            call.Begin();
            call.Search();
            call.FinalPrint();
            Console.ReadKey(); 
        }
    }
}


