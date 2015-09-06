/*
 * 堆排序;
 *  
 */

using System.Collections.Generic;

namespace SortConsole
{
    public class HeapSort
    {
        // 堆排序;
        public static void Sort(List<int> list,int top)
        {
            // only one element not need sort;
            if (list == null || list.Count <= 1)
            {
                return;
            }

            List<int> topNode = new List<int>();

            for (int i = list.Count / 2 - 1; i >= 0; i--)
            {
                HeapAdjust(list, i, list.Count);
            }

            for (int i = list.Count - 1; i >= list.Count - top; i--)
            {
                int temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                topNode.Add(temp);

                HeapAdjust(list, 0, i);
            }
        }

        // 构建堆;
        private static void HeapAdjust(List<int> list,int parent,int length)
        {
            int tmp=list[parent];
            int child = 2 * parent + 1;
            while(child<length)
            {
                if (child + 1 < length && list[child] < list[child + 1])
                {
                    ++child;
                }

                if(tmp>=list[child])
                {
                    break;
                }

                list[parent] = list[child];
                parent = child;
                child = 2 * parent + 1;
            }
        }
    }
}
