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

            // 调整序列的前半部分元素,调整完之后第一个元素是序列中的最小的元素;
            // list.Count / 2 - 1是最后一个非叶子结点;
            for (int i = list.Count / 2 - 1; i >= 0; --i)
            {
                HeapAdjust(list, i, list.Count);
            }

            // 从最后一个元素开始对序列进行调整,不断地缩小调整范围,直到第一个元素;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                // 将当前的大根和最后一个交换,则将最大的直接放在最后一个;
                // 它将不再参与排序;故长度为i;
                int temp = list[0];
                list[0] = list[i];
                list[i] = temp;
                HeapAdjust(list, 0, i);
            }

        }

        // 构建堆(大根堆),调整堆;
        private static void HeapAdjust(List<int> list,int parent,int length)
        {
            int tmp=list[parent];

            // 子节点的位置=2*(父节点位置)+1
            int child = 2 * parent + 1;

            while(child<length)
            {
                // 得到子节点中的最大的那个节点;
                if (child + 1 < length && list[child] < list[child+1])
                {
                    ++child;
                }

                // 如果父节点比子节点大,直接退出;
                // 否则,把父节点和子节点互换位置;
                if(tmp>list[child])
                {
                    break;
                }

                // 将子节点赋值给父节点;
                int swap = list[parent];
                list[parent] = list[child];
                list[child] = swap;
                // 子节点位置赋值给父节点;
                parent = child;
                // 当前的父节点变成子节点,子节点变成父节点;
                child = 2 * parent + 1;
            }
        }
    }
}
