using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Businesslogic

    {
        int c, r;
        int[,] arr = new int[10,10];

        public void Matrix()
        {
            Console.WriteLine("Enter The Number of Rows : ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Number of Columns : ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements");

            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void row()
        {
            int x;
            for (int i = 1; i <= c; i++)
            {
                x = 0;
                for (int j = 1; j <= r; j++)
                {
                    x = r + arr[i, j];
                }
                Console.WriteLine("{0} Row Sum : {1}", i, x);
            }
        }
         public void col()
        {
            int y;
            for(int j=1; j <= r; j++)
            {
                y = 0;
                for(int i=1;i<=c;i++)
                {
                    y = c + arr[i, j];
                }
                Console.WriteLine("{0} Column Sum : {1}", j, y);
            }
        }
    }
}
 

