using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            Console.WriteLine("test1");
            int[] array1 = new int[] {1 ,2};
            Console.WriteLine("this: {0}", array1[1]);

            string[] weekDays = {"sun", "mon", "tue", "wen", "thu", "fri", "sat"};
            Console.WriteLine("{0}", weekDays[0]);

            int[,] array2 = {
                {1,2},{3,4},{5,6},{7,8}
            };
            System.Console.WriteLine("{0}", array2[0, 0]);
            System.Console.WriteLine("{0}", array2.Length);

            int[][] jugArray = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6}
            };
            System.Console.WriteLine("{0}", jugArray[1][1]);

        }
    }
}

