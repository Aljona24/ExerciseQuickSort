using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[10];
            Random r = new Random();
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = r.Next(1, 100);
            }
            foreach (int i in testArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Sorting.QuickSort(testArray, 0, testArray.Length - 1);
            foreach (int i in testArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
