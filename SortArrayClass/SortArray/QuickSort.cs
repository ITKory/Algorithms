using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class QuickSort
    {
        int partition(int[] array, int left, int right)
        {
            int buff;
            int marker = left;
            for (int i = left; i <= right; i++)
            {
                if (array[i] < array[right]) 
                {
                    buff = array[marker];
                    array[marker] = array[i];
                    array[i] = buff;
                    marker += 1;
                }
            }
        
            buff = array[marker];
            array[marker] = array[right];
            array[right] = buff;
            return marker;
        }

       public void Sort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = partition(array, left, right);
            Sort(array, left, pivot - 1);
            Sort(array, pivot + 1, right);
        }
    }
}
