using System;
using System.Collections.Generic;
using System.Diagnostics;
using SortConsole;

class Test
{
    private static List<int> mNumbers;

    static void Main(string[] args)
    {
        mNumbers = new List<int>();
       
        // origin number;
        resetNumber();
        Console.WriteLine("origin number=> ");
        TestDebug.log(mNumbers);

        // test Bubble;
        testBubble();
        // test InsertSort;
        testInsertSort();
        // test QuickSort;
        testQuickSort();
        // test HeapSort;
        testHeapSort();
        // test MergeSort;
        testMergeSort();


        Console.ReadLine();
    }

    static void resetNumber()
    {
        mNumbers.Clear();
        mNumbers.Add(3);
        mNumbers.Add(8);
        mNumbers.Add(6);
        mNumbers.Add(10);


        //for (int i = 9; i > 0; --i)
        //{
        //    mNumbers.Add(i);
        //}

    }

    static void testBubble()
    {
        // test Bubble;
        resetNumber();
        //  开始监视代码运行时间;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        BubbleSort.Sort(mNumbers);
        stopwatch.Stop();
        Console.WriteLine("test Bubble=> {0}毫秒", stopwatch.Elapsed.TotalMilliseconds);
        TestDebug.log(mNumbers);
    }

    static void testInsertSort()
    {
        // test InsertSort;
        resetNumber();
        //  开始监视代码运行时间;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        InsertSort.Sort(mNumbers);
        stopwatch.Stop();
        Console.WriteLine("test InsertSort=> {0}毫秒", stopwatch.Elapsed.TotalMilliseconds);
        TestDebug.log(mNumbers);
    }

    static void testQuickSort()
    {
        // test QuickSort;
        resetNumber();
        //  开始监视代码运行时间;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        QuickSort.Sort(mNumbers, 0, mNumbers.Count - 1);
        stopwatch.Stop();
        Console.WriteLine("test QuickSort=> {0}毫秒", stopwatch.Elapsed.TotalMilliseconds);
        TestDebug.log(mNumbers);
    }

    static void testHeapSort()
    {
        // test HeapSort;
        resetNumber();
        //  开始监视代码运行时间;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        HeapSort.Sort(mNumbers, mNumbers.Count);
        stopwatch.Stop();
        Console.WriteLine("test HeapSort=> {0}毫秒", stopwatch.Elapsed.TotalMilliseconds);
        TestDebug.log(mNumbers);
    }

    static void testMergeSort()
    {
        // test MergeSort;
        resetNumber();
        //  开始监视代码运行时间;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        MergeSort.Sort(mNumbers,0,mNumbers.Count-1);
        stopwatch.Stop();
        Console.WriteLine("test MergeSort=> {0}毫秒", stopwatch.Elapsed.TotalMilliseconds);
        TestDebug.log(mNumbers);
    }
}

