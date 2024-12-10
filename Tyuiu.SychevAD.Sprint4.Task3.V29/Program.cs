using Tyuiu.SychevAD.Sprint4.Task3.V29.Lib;
namespace Tyuiu.SychevAD.Sprint4.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { 9, 9, 8, 6, 9 },
                { 5, 8, 8, 8, 7 },
                { 6, 5, 9, 7, 9 },
                { 7, 7, 9, 7, 8 },
                { 8, 5, 8, 5, 5 }};

            int rows = array.GetUpperBound(0) + 1; //количество строк
            int colums = array.Length / rows; // количество столбцов

            Console.Title = "Спринт #4 | Выполнила: Сычев А.Д. | АСОиУБ 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                                       *");
            Console.WriteLine("* Задание #3                                                                                       *");
            Console.WriteLine("* Вариант #29                                                                                      *");
            Console.WriteLine("* Выполнила: Сычев Александр Дмитриеви | АСОиУБ 24-1                                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в       *");
            Console.WriteLine("* диапазоне от 2 до 9. Найдите максимальный элемент в последней строке массива                     *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Максимальный элемент в последней строчке массива: " + res);
            Console.ReadKey();
        }
    }
}