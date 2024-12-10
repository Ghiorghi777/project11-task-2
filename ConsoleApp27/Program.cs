using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    { 
        static int MaxOfTwo(int a, int b)
        {
            return (a > b) ? a : b;  
        }

        static void Main()
        {
           
            Console.WriteLine("Введите 8 различных чисел:");

            int[] numbers = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
 
            int max = numbers[0];  

            for (int i = 1; i < 8; i++)
            {
                max = MaxOfTwo(max, numbers[i]); 
            }
            Console.WriteLine("Максимальное число: " + max);
            Console.ReadKey();
        }
    }

}
