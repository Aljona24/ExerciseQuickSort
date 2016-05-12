using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseQuickSort
{
    public static class Sorting
    {
        // variable name
        // while/if bloks
        public static void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            int temp;
            int x = array[leftIndex + (rightIndex - leftIndex) / 2];
            int i = leftIndex;
            int j = rightIndex;
            while (i <= j)
            {
                while (array[i] < x) { i++; }
                while (array[j] > x) { j--; }
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < rightIndex)
            { QuickSort(array, i, rightIndex); }

            if (leftIndex < j)
            { QuickSort(array, leftIndex, j); }
        }
    }
}
