using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] array= new int[2][];
            //array[0] = new int[3] { 1, 2, 3 };
            //array[1] = new int[4] { 4, 5, 6, 7 };
            //for(int i=0; i< array.Length; i++)
            //{
            //    for(int j=0; j< array[i].Length; j++)
            //    {
            //        Console.WriteLine(array[i][j]) ;
            //    }
            //}

            //int[][,] jArray = new int[2][,];

            //jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };

            //for (int i = 0; i < jArray.Length; i++)
            //{
            //    for (int j = 0; j < jArray[i].Length; j++)
            //    {
            //        Console.WriteLine(jArray[i][i,j]);
            //    }
            //}

            //var row = int.Parse(Console.ReadLine());
            //int[][] jagged = new int[row][];
            //for(var i=0; i< row; i++)
            //{
            //    var numbers = Console.ReadLine().Split(' ');
            //    jagged[i] = new int[numbers.Length];
            //    for(var j=0;j<numbers.Length; j++)
            //    {
            //        jagged[i][j] = int.Parse(numbers[j]);

            //    }
            //}
            int[] ages = new int[] { 12, 25, 24, 14, 72, 90 };
            foreach(var age in ages)
            {
                Console.WriteLine(age);
            }
            //var rows = int.Parse(Console.ReadLine());
            //int[][] jassica = new int[rows][];
            //for(var i=0; i<rows; i++)
            //{
            //    var number = Console.ReadLine().Split(' ');
            //    jassica[i] = new int[number.Length];
            //    for(var j=1; j<number.Length; j++)
            //    {
            //        jassica[i][j] = int.Parse(number[j]);
            //    }
            //}
        }
    }
}
