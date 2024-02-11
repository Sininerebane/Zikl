using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zikl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int cyсleNumbers;
            Console.WriteLine("Сколько раз вы хотите, чтобы цикл повториться?");
            cyсleNumbers= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cyсleNumbers; i++)
            {
                Console.WriteLine($" Этот цикл повторяется {i+1}");
            }
            Console.ReadKey();
        }
    }
}
