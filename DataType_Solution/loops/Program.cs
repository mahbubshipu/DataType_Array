using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=10, j=0; i >0 && j<10; i--, j++)
            //{
            //    Console.WriteLine($"I:{i}, J:{j}");
               
            //}
            //int z = 0;
            //while (z > 0)
            //{
            //    int t = z % 2;
            //    z /= 2;
            //    Console.Write(t);
            //}
            //Console.WriteLine();

            //int p = 0;
            //do
            //{
            //    int q = p % 2;
            //    p /= 2;
            //    Console.Write(q);
            //} while (p > 0);
            //Console.WriteLine();

            int[,] numbers = new int[3, 4]
            {
                {3,4,5,6},
                {7,8,9,10},
                {11,12,13,14}
            };
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write(numbers[i, j]+ ",");
                }
                Console.WriteLine();
            }

        }
    }
}
