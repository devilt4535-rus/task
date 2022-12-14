using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class nums
    {
        public void FindUniqueNumberArray(int[] arrayNumbers)
        {
            if (arrayNumbers.Length % 2 != 0)
            {
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    int count = 0;
                    int numberInArray = arrayNumbers[i];
                    foreach (var number in arrayNumbers)
                    {
                        if (number == numberInArray)
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        numberInArray = arrayNumbers[i];
                        Console.WriteLine();
                        Console.WriteLine($"Уникальное число из массива - {numberInArray}");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка");
                Console.WriteLine();
            }
        }
    }
}
