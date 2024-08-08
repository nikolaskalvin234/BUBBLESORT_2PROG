using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Array sebelum diurutkan:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int[] bubbleSortedArray = BubbleSort(arr);

        Console.WriteLine("BubbleSort Array setelah diurutkan:");
        foreach (int num in bubbleSortedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int[] exchangeSortedArray = ExchangeSort(arr);

        Console.WriteLine("ExcangeSort Array setelah diurutkan:");
        foreach (int num in exchangeSortedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int[] selectionSortedArray = SelectionSort(arr);

        Console.WriteLine("SelectionSort Array setelah diurutkan:");
        foreach (int num in selectionSortedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int[] insertionSortedArray = InsertionSort(arr);

        Console.WriteLine("InsertionSort Array setelah diurutkan:");
        foreach (int num in insertionSortedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static int[] BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                }

            }
        }
        return arr;
    }

    public static int[] ExchangeSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[i])
                {
                    // Tukar elemen
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        return arr;
    }

    public static int[] SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
        return arr; // Mengembalikan array yang telah diurutkan
    }

    public static int[] InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i;
            while (j >= 1 && arr[j - 1] > key)
            {
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = key;
        }
        return arr;
    }


}




