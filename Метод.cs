using System;

namespace _1st_lesson
{
    class Programm
    {


        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }


            int min = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int y = i + 1; y < result.Length; y++)
                {
                    if (result[i] > result[y])
                    {
                        min = result[i];

                        result[i] = result[y];

                        result[y] = min;
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            GetArrayFromConsole();

        }

    }
}
