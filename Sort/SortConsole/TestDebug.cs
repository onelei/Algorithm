using System;
using System.Collections.Generic;
namespace SortConsole
{
    public class TestDebug
    {
        public static void log(List<int> mNumbers)
        {
            for (int i = 0; i < mNumbers.Count; ++i)
            {
                Console.Write(mNumbers[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
