using System;
using System.Diagnostics;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the amount of numbers per array: ");
        int arraysize = int.Parse(Console.ReadLine());
        Random rnd = new Random();
      //These will be used to track the time spent sorting:
        long bubbleTime = 0;
        long selectionTime = 0;
      //loop (500) creating identical arrays and sorting them
        for (int k = 0; k <= 500; k++)
        {
            int[] numberArray = new int[arraysize];
            int[] numberArrayTwo = new int[arraysize];
            for (int i = 0; i < arraysize; i++)
            numberArray[i] = rnd.Next();
            numberArray.CopyTo(numberArrayTwo, 0);
            //Bubble Sort time:           
            bubbleTime+= BubbleSort(ref numberArray);         
            //Selection Sort time:    
           selectionTime += SelectionSort(ref numberArrayTwo);
          Console.Write("Sorted array " + k +"\r");   
        }
      Console.WriteLine("Bubble time (500): " + bubbleTime +" milliseconds");
      Console.WriteLine("Selection time (500): " + selectionTime +" milliseconds");
      //Time Reset 
      bubbleTime = 0;
      selectionTime = 0;
      Console.WriteLine("--------------------------------------");
      //loop (2500) creating identical arrays and sorting them
       for (int k = 0; k <= 2500; k++)
        {
            int[] numberArray = new int[arraysize];
            int[] numberArrayTwo = new int[arraysize];
            for (int i = 0; i < arraysize; i++)
            numberArray[i] = rnd.Next();
            numberArray.CopyTo(numberArrayTwo, 0);
            //Bubble Sort time:           
            bubbleTime+= BubbleSort(ref numberArray);         
            //Selection Sort time:    
           selectionTime += SelectionSort(ref numberArrayTwo);
          Console.Write("Sorted array " + k +"\r");   
        }
      Console.WriteLine("Bubble time (2500): " + bubbleTime +" milliseconds");
      Console.WriteLine("Selection time (2500): " + selectionTime +" milliseconds");
      //Time Reset 
      bubbleTime = 0;
      selectionTime = 0;
      Console.WriteLine("--------------------------------------");
      //loop (5000) creating identical arrays and sorting them
       for (int k = 0; k <= 5000; k++)
        {
            int[] numberArray = new int[arraysize];
            int[] numberArrayTwo = new int[arraysize];
            for (int i = 0; i < arraysize; i++)
            numberArray[i] = rnd.Next();
            numberArray.CopyTo(numberArrayTwo, 0);
            //Bubble Sort time:           
            bubbleTime+= BubbleSort(ref numberArray);         
            //Selection Sort time:    
           selectionTime += SelectionSort(ref numberArrayTwo);
          Console.Write("Sorted array " + k +"\r");   
        }
      Console.WriteLine("Bubble time (5000): " + bubbleTime +" milliseconds");
      Console.WriteLine("Selection time (5000): " + selectionTime +" milliseconds");
    }
  //Selection Sort Algorithm:
    public static long SelectionSort(ref int[] array)
    {
        int Min = 0;
        int length = array.Length;
      // Creating StopWatch and immediately starting it 
      var sw = Stopwatch.StartNew();
        for (int i = 0; i < length; i++)
        {
            Min = i;
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[Min])
                    Min = j;
            }
            int temp = array[Min];
            array[Min] = array[i];
            array[i] = temp;
        }
        sw.Stop();
      //Returning the StopWatch time
      return sw.ElapsedMilliseconds;
    }
  //Bubble Sort Algorithm:
    public static long BubbleSort(ref int[] array)
    {
        int length = array.Length;
      // Creating StopWatch and immediately starting it 
        var sw = Stopwatch.StartNew();
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
      sw.Stop();
     //Returning the StopWatch time
      return sw.ElapsedMilliseconds;
    }
}