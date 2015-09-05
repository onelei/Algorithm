using System;
using System.Collections.Generic;

using SortConsole;

class Test
{
    private static List<int> mNumbers;

    static void Main(string[] args)
    {
        mNumbers = new List<int>();
       
        //for (int i = 9; i > 0; --i)
        //{
        //    mNumbers.Add(i);
        //}

        // origin number;
        resetNumber();
        Console.WriteLine("origin number=> ");
        Debug.log(mNumbers);

        // test Bubble;
        resetNumber();
        Console.WriteLine("test Bubble=> ");
        BubbleSort.Sort(mNumbers);
        Debug.log(mNumbers);

        // test InsertSort;
        resetNumber();
        Console.WriteLine("test InsertSort=> ");
        InsertSort.Sort(mNumbers);
        Debug.log(mNumbers);

        Console.ReadLine();
    }

    static void resetNumber()
    {
        mNumbers.Clear();
        mNumbers.Add(3);
        mNumbers.Add(8);
        mNumbers.Add(6);
        mNumbers.Add(10);
    }
}

