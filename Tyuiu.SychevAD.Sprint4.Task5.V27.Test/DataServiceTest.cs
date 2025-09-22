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

            // ���� 1: ������ � �������������� ����������
            int[,] matrix1 = new int[5, 5]
            {
                { 1, -2,  3, -4,  5 },
                { -1, 2, -3,  4, -5 },
                { 0, -1,  2, -2,  3 },
                { 1,  2,  3,  4,  5 },
                { -1, -2, -3, 0,  1 }
            };

            int result1 = ds.Calculate(matrix1);
            int wait1 = 9; // 9 ������������� ���������
            Assert.AreEqual(wait1, result1);

            // ���� 2: ������ ��� ������������� ���������
            int[,] matrix2 = new int[5, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 0, 1, 2, 3, 4 },
                { 1, 1, 1, 1, 1 },
                { 2, 2, 2, 2, 2 },
                { 3, 3, 3, 3, 3 }
            };

            int result2 = ds.Calculate(matrix2);
            int wait2 = 0; // 0 ������������� ���������
            Assert.AreEqual(wait2, result2);

            // ���� 3: ��� �������� �������������
            int[,] matrix3 = new int[5, 5]
            {
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 }
            };

            int result3 = ds.Calculate(matrix3);
            int wait3 = 25; // 25 ������������� ���������
            Assert.AreEqual(wait3, result3);

            // ���� 4: ��������� �������� (��������� ������)
            int[,] matrix4 = new int[5, 5]
            {
                { -5,  7,  0, -1,  2 },
                { -4,  6, -2,  3, -3 },
                { -5,  5, -5,  5, -5 },
                {  0,  1, -1,  2, -2 },
                {  7, -5,  6, -4,  3 }
            };

            int result4 = ds.Calculate(matrix4);
            int wait4 = 10; // 10 ������������� ���������
            Assert.AreEqual(wait4, result4);
        }

        [TestMethod]
        public void ValidEmptyMatrix()
        {
            DataService ds = new DataService();

            // ���� � ������ ��������
            int[,] matrix = new int[0, 0];
            int result = ds.Calculate(matrix);
            int wait = 0;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidSingleElement()
        {
            DataService ds = new DataService();

            // ���� � ����� ��������� (�������������)
            int[,] matrix1 = new int[1, 1] { { -5 } };
            int result1 = ds.Calculate(matrix1);
            int wait1 = 1;
            Assert.AreEqual(wait1, result1);

            // ���� � ����� ��������� (�������������)
            int[,] matrix2 = new int[1, 1] { { 7 } };
            int result2 = ds.Calculate(matrix2);
            int wait2 = 0;
            Assert.AreEqual(wait2, result2);

            // ���� � ����� ��������� (�������)
            int[,] matrix3 = new int[1, 1] { { 0 } };
            int result3 = ds.Calculate(matrix3);
            int wait3 = 0;
            Assert.AreEqual(wait3, result3);
        }
    }
}