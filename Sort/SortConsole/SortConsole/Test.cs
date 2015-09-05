using System;
using System.Collections.Generic;

using SortConsole;

class Test
{
    private static List<int> mNumbers;

    static void Main(string[] args)
    {
        mNumbers = new List<int>();

        for (int i = 9; i > 0; --i)
        {
            mNumbers.Add(i);
        }

        // origin number;
        Console.WriteLine("origin number=> ");
        Debug.log(mNumbers);

        // test Bubble;
        Console.WriteLine("test Bubble=> ");
        SortBubble.Sort(mNumbers);
        Debug.log(mNumbers);

        Console.ReadLine();
    }
}

