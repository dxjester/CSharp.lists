using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = new List<double>();
            Random rList = new Random();

            double temp;

            for (int i = 0; i < 20; i++)
            {
                temp = rList.NextDouble();
                myList.Add(temp);
            }

            System.Console.WriteLine("The size of your list is: " + myList.Count);
            myList.ForEach(Console.WriteLine);
            System.Console.ReadLine();
        }
    }
}
