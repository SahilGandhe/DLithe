using System;


namespace InterfaceDemo
{
    class Task26
    {
        public void Show(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        public static void Main(string[] args)
        {

            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };// 2-d array
            int[] arr = new int[5];//creating array  
            arr[0] = 43;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 18;
            int[][] arr2 = new int[2][];// Declare the jagged  array  

            Console.WriteLine("Param arrays:-  ");
            arr2[0] = new int[] { 11, 21, 56, 78 };// Initialize the jagged array
            Task26 obj = new Task26(); // Creating Object  
            obj.Show(2, 4, 6, 8, 10, 12, 14);

            arr2[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            Console.WriteLine("array min method:-  ");
            printMin(arr);


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("2-d array:-   ");
            Console.WriteLine("-------------------");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Jagged array:-  ");
            Console.WriteLine("-------------------");


            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    System.Console.Write(arr2[i][j] + " ");
                }
                System.Console.WriteLine();
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("-------------------");


            void printMin(int[] arr)
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }
                Console.WriteLine("Minimum element is: " + min);
            }
        }
    }     