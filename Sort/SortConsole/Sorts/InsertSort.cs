/*
 * 插入排序;
 * 每次处理就是将无序数列的第一个元素与有序数列的元素从后往前逐个进行比较;
 * 找出插入位置，将该元素插入到有序数列的合适位置中;
 *  
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
