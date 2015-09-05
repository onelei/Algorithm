/*
 *  直接插入排序;
 */

using System.Collections.Generic;

namespace SortConsole
{
    public class InsertSort
    {
        public static void Sort(List<int> tmpList)
        {
            // only one element not need sort;
            if (tmpList == null || tmpList.Count <= 1)
            {
                return;
            }

            for (int i = 1; i < tmpList.Count;++i)
            {
                int curNumber = tmpList[i];
                int curIndex=i-1;
                // 将当前的元素插入到,之前排好的队列里;
                // 将之前的向后移动;
                while(curNumber<tmpList[curIndex])
                {
                    tmpList[curIndex+1]=tmpList[curIndex];
                    --curIndex;
                }
                tmpList[curIndex+1] = curNumber;
            }
        }
    }
}
