using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {3,6,5,7,9,1,8};
        Console.WriteLine("原始数组：");
        foreach (int item in array)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();

        BubbleSort(array);
        Console.WriteLine("冒泡排序后的数组:");
        foreach(int i in array)
        {
            Console.Write(i+" ");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n-i-1; j++)
            {
                if(array[j]>array[j+1])
                {
                     int temp = array[j];
                     array[j] = array[j + 1];
                     array[j+1] = temp;
                }    
            }
        }
    }
}