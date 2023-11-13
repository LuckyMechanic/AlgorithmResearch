using System;
using System.Data;

/// <summary>
/// 交换排序
/// </summary>
class Program
{
    
    //冒泡排序
    /*
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
   
 */
    //快速排序
    static void Main(string[] args)
    {
        int[] array = {10, 7, 8, 9, 1, 5};
        Console.WriteLine("原始数组：");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        QuickSort(array,0,array.Length - 1);
        Console.WriteLine("快速排序后数组：");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    static void QuickSort(int[] arr,int low,int hight)
    {
        if(low < hight)
        {
            int pivot = Partition(arr,low,hight);
            QuickSort(arr,low,pivot-1);
            QuickSort(arr,pivot +1,hight);
        }
    }

    static int Partition(int[] arr,int low,int hight)
    {
        int pivot = arr[hight];
        int i = (low - 1);
        for (int j = low; j < hight; j++)
        {
            if(arr[j]<=pivot)
            {
                i++;
                Swap(arr,i,j);
            }
        }
        Swap(arr,i+1,hight);
        return i + 1;
    }

    static void Swap(int[] arr,int a,int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

   


}