using System;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 3.");
            int v = 32;
            Console.WriteLine( + ((v % 10) + 1) + " Вариант");

            Console.Write("Введите количество элементов:");
            var len = int.Parse(Console.ReadLine());

            var array = new int[len];

            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = int.Parse(Console.ReadLine());
            }

            
            int max = array[0];
            for (int i = 0; i < array.Length; i++)

                if (max <= array[i])
                {
                    max = array[i];
                    index = i;
                }
            Console.WriteLine("Индекс первого максимального элемента " + ": " + +index);



            Console.ReadKey();
        }
    }
}
