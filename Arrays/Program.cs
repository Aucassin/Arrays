using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[][] jagged = new int[2][];

            jagged[0] = new int[10];
            jagged[1] = new int[8];

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = rand.Next(1, 10);
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} |");
                }
                Console.WriteLine();
            }



            //Matrix
            //int[,] doubleArray = new int[5, 5];
            //Random rand = new Random();
            //doubleArray[0, 0] = 0;
            //doubleArray[0, 1] = 1;
            //doubleArray[0, 2] = 7;

            //for (int i = 0; i < doubleArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < doubleArray.GetLength(1); j++)
            //    {
            //        doubleArray[i, j] = rand.Next(1, 15);
            //    }
            //}

            //for (int i = 0; i < doubleArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < doubleArray.GetLength(1); j++)
            //    {
            //        Console.Write($"{doubleArray[i,j],2} | ");
            //    }
            //    Console.WriteLine();
            //}


            //7.2
            //List<string> daysofweek = new List<string>();
            //daysofweek.Add("Monday");
            //daysofweek.Add("Tuesday");
            //daysofweek.Add("Wednesday");
            //daysofweek.Add("Thursday");
            //daysofweek.Add("Friday");
            //daysofweek.Add("Saturday");
            //daysofweek.Add("Sunday");

            //foreach (var item in daysofweek)
            //    Console.WriteLine(item);


            //
            //List<int> daysofweek = new List<int>();
            //daysofweek.Add(1);
            //daysofweek.Add(2);
            //daysofweek.Add(3);
            //daysofweek.Add(4);

            //List<int> list2 = daysofweek;

            //foreach(var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(new string ('-',40));
            //daysofweek.Add(15);

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var day in daysofweek)
            //{
            //    Console.WriteLine(day);
            //}

            //int h = 15;
            //object y = h;
            //h = 16;
            //Console.WriteLine(y);

            //daysofweek.Add("Wednesday");
            //foreach (var day in daysofweek)
            //{
            //    Console.WriteLine(day);
            //}



            //string s = "Hello world!";
            //Console.WriteLine(s[0]);



            //7.1.1
            //int[] array1 = new int[101];
            //int count = 200;
            //for (int i = 0; i < 101; i++)
            //{
            //    array1[i] = count;
            //    count--;
            //}
            //foreach (var item in array1)
            //{
            //    Console.WriteLine(item);
            //    //if (item == 150)
            //    //    break;
            //}




            // 7.1
            //int[] array1 = new int[5];
            //Random rand = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    array1[i] = rand.Next(0, 15);
            //}
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.WriteLine(array1[i]);
            //}

            //Start
            //int[] array = new int[500];

            ////for (int i = 0; i < 500; i++)
            ////{
            ////    array[i] = i;
            ////}

            //array[1] = 43;
            //int a = 15;
            //int[] array1 = { 5, 2, 3, 4 };
        }
    }
}
