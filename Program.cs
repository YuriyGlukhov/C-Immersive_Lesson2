using System;
using System.Linq;

namespace C_Immersive_Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };


            int[] flatarray = array.Cast<int>().ToArray();

            Array.Sort(flatarray);

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i,j] = flatarray[index++];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine();
            }



        }
       
    }
}
