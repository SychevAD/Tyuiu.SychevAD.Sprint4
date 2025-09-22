using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SychevAD.Sprint4.Task5.V27.Lib
{
    public class DataService
    {
        public int Calculate(int[,] matrix)
        {
            // Количество ОТРИЦАТЕЛЬНЫХ элементов
            int count = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0) // проверка на отрицательность
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
