using System;
//using Linq;

namespace Module4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region duplicte
            int[] array = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
            int[] array2 = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            Console.WriteLine("The numbers in first array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine("\nThe numbers in the second array are: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("{0}  ", array2[i]);
            }
            #endregion

            #region input
            int[] arr = { 1, 2, 3, 4, 1, 2, 3, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"The duplicates are: { arr[i]}");
                    }
                }
            }

            //int n;
            //Console.WriteLine("Enter how many values you want to enter: ");
            //n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine("enter your values: ");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        {
            //            arr[i] = int.Parse(Console.ReadLine());
            //        }
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine($"The duplicates are: {arr[i]}");
            //        }
            //    }

            //}

            //int[] arr = new int[5];
            //Console.WriteLine("Enter 5 items: ");
            ////Console.WriteLine(Console.ReadLine());
            //int numbers = Int32.TryParse( , out numbers);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        {
            //            arr[i] = Int32.Parse(Console.ReadLine());
            //        }
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine($"The duplicates are: {arr[i]}");
            //        }
            //    }
            //}


            //int[] yourArray = new int[5];
            //int i, j, numb, count = 0;

            //Console.WriteLine("Enter how much items you want to enter: ");
            //numb = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your items: ");
            //for (i = 0; i < numb; i++)
            //{
            //    yourArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (j = i + 1; j < numb; j++)
            //{
            //    if (yourArray[i] == yourArray[j])
            //    {
            //        count++;
            //        break;
            //    }
            //}
            //Console.WriteLine($"In your array there are {count} duplicates.");
            #endregion
            Console.ReadLine();
        }



    }
}