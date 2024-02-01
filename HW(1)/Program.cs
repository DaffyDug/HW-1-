using System;

namespace ConsoleApp6;

internal class Program
{
    private static void Main(string[] args)
    {
        //сортировка в обратную сторону 
        int[] arr3 = new int[7] { 3, 2, 1, 7, 3, 5, 9 };
        Sort_ARR(arr3);
        Console.WriteLine(' '); 
        Console.WriteLine(' ');
        int[] arr = new int[7] { 4, 5, 4, 5, 1, 2, 0 };
        int[] arr2 = new int[7] {9, 1, 7, 4, 1, 2, 0 };
        //сложение двух массивов
        ARR_Plus_ARR(arr, arr2);
    }

    private static void Swap(int[] arr, int a, int a2)
    {
        int temp = arr[a];
        arr[a] = arr[a2];
        arr[a2] = temp;
    }

    private static void Sort_ARR(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    Swap(arr, i, j);
                }
            }
        }
        foreach (int item in arr)
        {
            Console.Write(item+" ");
        }
    }


    private static void ARR_Plus_ARR(int[] arr, int[] arr2)
    {
        int[] arr3 = new int[arr.Length + arr2.Length];
        for (int j = 0; j < arr.Length; j++)
        {
            arr3[j] = arr[j];
            arr3[arr.Length+j] = arr2[j];
        }

        foreach (int i in arr3)
        {
            Console.Write(i + " ");
        }
    }
}
