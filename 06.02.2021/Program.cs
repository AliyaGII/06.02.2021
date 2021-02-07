using System;

namespace _06._04._2021
{
    static class ArrayHelper
    {
        //Pop
        public static T Pop<T>(ref T[] arr)
        {
            T deleted = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return deleted;
        }

        //Push
        public static int Push<T>(ref T[] arr, T added)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            return arr.Length;
        }

        //Shift
        public static T Shift<T>(ref T[] arr)
        {
            Array.Reverse(arr);
            T added = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return added;
        }

        //Unshift
        public static int UnShift<T>(ref T[] arr, T added)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            Array.Reverse(arr);
            return arr.Length;
        }

        //Slice
        public static T[] Slice<T>(ref T[] arr)
        {
            T[] arr2 = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            return arr2;
        }

        //Slice with begin and end
        public static T[] Slice<T>(ref T[] arr, int begin, int end)
        {
            if (begin < 0)
            {
                begin = arr.Length - Math.Abs(begin);
            }
            if (end < 0)
            {
                end = arr.Length - Math.Abs(end);
            }
            T[] arr2 = new T[end - begin];
            int g = 0;
            for (int i = begin; i < end; i++)
            {
                arr2[g] = arr[i];
                g++;
            }

            return arr2;
        }

        //Slice with begin
        public static T[] Slice<T>(ref T[] arr, int begin)
        {
            if (begin < 0)
            {
                begin = arr.Length - Math.Abs(begin);
            }

            T[] arr2 = new T[arr.Length - begin];

            int g = 0;
            for (int i = begin; i < arr.Length; i++)
            {
                arr2[g] = arr[i];
                g++;
            }
            return arr2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[] { "ant", "bison", "camel", "duck", "elephant" };
            Console.ReadKey();
        }
    }
}




