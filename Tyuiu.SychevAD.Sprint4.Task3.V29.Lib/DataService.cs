using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SychevAD.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int count = 1;
            int columnToSum = 1;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                }
                count *= array[i, 0];
            }
            return count;
        }
    }
}