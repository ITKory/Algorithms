﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class BubbleSort
    {
        private int[] _array;
        private int _n;
        private int buff;
        public int[]  Sort(int[] array, int n )
        {
            _n = n;
            _array = new int[_n];
            _array = array;
            for(int i = 0; i<_n;i++)
                for (int j = 1; j < _n; j++)
                {
                    if (_array[j - 1] > _array[j])
                    {
                        buff = _array[j];
                        _array[j] = _array[j - 1];
                        _array[j - 1] = buff; 
                    }

                }

            array = _array;
            return array; 
            
        }
        
    }
}
