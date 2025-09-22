using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SychevAD.Sprint4.Task5.V27.Lib;

namespace Tyuiu.SychevAD.Sprint4.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Сычев А. Д. | АСОиУб 24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -5 до 7.               *");
            Console.WriteLine("* Найти количество отрицательных элементов.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 5;
            int[,] mtrx = new int[rows, columns];

            Random random = new Random();

            Console.WriteLine("Размер массива: 5 x 5");
            Console.WriteLine("Диапазон случайных чисел: от -5 до 7");
            Console.WriteLine();

            // Заполняем массив случайными числами
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = random.Next(-5, 8); // от -5 до 7 включительно
                }
            }

            Console.WriteLine("\nСгенерированный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Количество отрицательных элементов = " + res);

            Console.ReadLine();
        }
    }
}