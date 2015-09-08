/*
 * 冒泡排序; 
 * 冒泡排序算法的运作如下：（从后往前）;
 * 比较相邻的元素。如果第一个比第二个大，就交换他们两个;
 * 对每一对相邻元素作同样的工作，从开始第一对到结尾的最后一对。在这一点，最后的元素应该会是最大的数;
 * 针对所有的元素重复以上的步骤，除了最后一个;
 * 持续每次对越来越少的元素重复上面的步骤，直到没有任何一对数字需要比较;
 *
 */

using System.Collections.Generic;

namespace SortConsole
{
    public class BubbleSort
    {    
        // from small to big;
        public static void Sort(List<int> tmpList)
        {
            // only one element not need sort;
            if (tmpList == null || tmpList.Count<=1)
            {
                return;
            }
            bool isExchange = true;
            int length=tmpList.Count;
            int tmp;
            for (int i = 0; i < length-1;++i )
            {
                isExchange = false;
                for (int j = 0; j < length-1-i;j++ )
                {
                    // 每趟和相邻的相互比较;
                    // 将最小的和前面的交换,最小的放在最前面;
                    if(tmpList[j+1]<tmpList[j])
                    {
                        tmp = tmpList[j];
                        tmpList[j] = tmpList[j+1];
                        tmpList[j+1] = tmp;
                        isExchange = true;
                    }
                }

                if (!isExchange)
                {
                    break;
                }
            }
        }

    }
}
