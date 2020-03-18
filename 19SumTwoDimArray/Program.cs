using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19SumTwoDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3,3];
            int[,] array2 = new int[3, 3];
            int[,] sum = new int[3, 3];


            // First Array Elements Read Loop
            
            Console.WriteLine("Enter the 9 elements of first array" );
            for (int row = 0; row < 3; row++)
            
                for (int coloumn = 0; coloumn < 3; coloumn++)
                
                    array1[row, coloumn] = int.Parse(Console.ReadLine());
                
            
            // Frist Array Elements Write Loop

            for(int row = 0; row<3; row++)
            {
                for(int coloumn =0; coloumn <3; coloumn++ )
                
                    Console.Write(array1[row, coloumn] + "\t");
                    Console.WriteLine();
                
            }

            // Second Array Elements Read Loop

            Console.WriteLine("Enter the 9 elements of second array");
            for (int row = 0; row < 3; row++)

                for (int coloumn = 0; coloumn < 3; coloumn++)

                    array2[row, coloumn] = int.Parse(Console.ReadLine());


            // Second Array Elements Write Loop

            for (int row = 0; row < 3; row++)
            {
                for (int coloumn = 0; coloumn < 3; coloumn++)

                    Console.Write(array2[row, coloumn] + "\t");
                Console.WriteLine();

            }

            // Sum of both the arrays

            for(int row = 0; row <3; row++)
            {
                for (int coloumn= 0; coloumn<3; coloumn++ )
                {
                    sum[row, coloumn] = array1[row,coloumn] + array2[row,coloumn];
                }
            }


            //Display the Sum


            Console.WriteLine("********Sum is *********");

            for (int row = 0; row < 3; row++)
            {
                for (int coloumn = 0; coloumn < 3; coloumn++)
                {
                    Console.Write(sum[row, coloumn] + "\t");
                }

                Console.WriteLine();
            }



        }
    }
}
