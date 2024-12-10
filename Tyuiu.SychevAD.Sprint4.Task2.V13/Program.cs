using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SychevAD.Sprint4.Task2.V13.Lib;

namespace Tyuiu.SychevAD.Sprint4.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();//
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Сычев А.Д. | АСОиУб 24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать произведение четных         *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите количесвто элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                numArray[i] = rnd.Next(2, 10);
            }

            Console.WriteLine("Массив: " + "[{0}]", string.Join(",", numArray));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numArray);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}