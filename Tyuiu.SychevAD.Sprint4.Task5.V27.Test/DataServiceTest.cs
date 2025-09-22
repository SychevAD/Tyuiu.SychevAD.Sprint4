using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint4.Task5.V27.Lib;

namespace Tyuiu.SychevAD.Sprint4.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тест 1: Массив с отрицательными элементами
            int[,] matrix1 = new int[5, 5]
            {
                { 1, -2,  3, -4,  5 },
                { -1, 2, -3,  4, -5 },
                { 0, -1,  2, -2,  3 },
                { 1,  2,  3,  4,  5 },
                { -1, -2, -3, 0,  1 }
            };

            int result1 = ds.Calculate(matrix1);
            int wait1 = 9; // 9 отрицательных элементов
            Assert.AreEqual(wait1, result1);

            // Тест 2: Массив без отрицательных элементов
            int[,] matrix2 = new int[5, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 0, 1, 2, 3, 4 },
                { 1, 1, 1, 1, 1 },
                { 2, 2, 2, 2, 2 },
                { 3, 3, 3, 3, 3 }
            };

            int result2 = ds.Calculate(matrix2);
            int wait2 = 0; // 0 отрицательных элементов
            Assert.AreEqual(wait2, result2);

            // Тест 3: Все элементы отрицательные
            int[,] matrix3 = new int[5, 5]
            {
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 }
            };

            int result3 = ds.Calculate(matrix3);
            int wait3 = 25; // 25 отрицательных элементов
            Assert.AreEqual(wait3, result3);

            // Тест 4: Смешанные значения (граничные случаи)
            int[,] matrix4 = new int[5, 5]
            {
                { -5,  7,  0, -1,  2 },
                { -4,  6, -2,  3, -3 },
                { -5,  5, -5,  5, -5 },
                {  0,  1, -1,  2, -2 },
                {  7, -5,  6, -4,  3 }
            };

            int result4 = ds.Calculate(matrix4);
            int wait4 = 10; // 10 отрицательных элементов
            Assert.AreEqual(wait4, result4);
        }

        [TestMethod]
        public void ValidEmptyMatrix()
        {
            DataService ds = new DataService();

            // Тест с пустым массивом
            int[,] matrix = new int[0, 0];
            int result = ds.Calculate(matrix);
            int wait = 0;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidSingleElement()
        {
            DataService ds = new DataService();

            // Тест с одним элементом (отрицательным)
            int[,] matrix1 = new int[1, 1] { { -5 } };
            int result1 = ds.Calculate(matrix1);
            int wait1 = 1;
            Assert.AreEqual(wait1, result1);

            // Тест с одним элементом (положительным)
            int[,] matrix2 = new int[1, 1] { { 7 } };
            int result2 = ds.Calculate(matrix2);
            int wait2 = 0;
            Assert.AreEqual(wait2, result2);

            // Тест с одним элементом (нулевым)
            int[,] matrix3 = new int[1, 1] { { 0 } };
            int result3 = ds.Calculate(matrix3);
            int wait3 = 0;
            Assert.AreEqual(wait3, result3);
        }
    }
}