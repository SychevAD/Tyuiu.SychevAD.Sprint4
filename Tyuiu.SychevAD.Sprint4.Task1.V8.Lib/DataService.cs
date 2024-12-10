﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SychevAD.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    s += array[i];
                }
            }
            return s;
        }
    }
}