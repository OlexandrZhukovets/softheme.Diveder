using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{


    class Program
    {
        static void Divider(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if ((x % (i + 1)) == 0)
                {
                    Console.WriteLine(i+1);
                }
            }
        }

        static void Main(string[] args)
        {
           //  В качестве аргумента ввести нужное число и в консоли выведутся все целочисленные делители
                Divider(2);
               Console.ReadKey();

        }
    }
}
