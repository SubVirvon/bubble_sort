using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 10;
            int[] array = new int[arrayLength];
            Random random = new Random();
            int minValue = 0;
            int maxValue = 100;

            Console.Write("Массив до сортировки: ");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
                Console.Write(array[i] + " ");
            }

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tempNumber = array[j];

                        array[j] = array[j + 1];
                        array[j + 1] = tempNumber;
                    }
                }
            }

            Console.Write("\nМассив после сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
