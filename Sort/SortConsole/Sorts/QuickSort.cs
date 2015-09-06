/*
 * 快速排序;
 * 通过一趟排序将要排序的数据分割成独立的两部分;
 * 其中一部分的所有数据都比另外一部分的所有数据都要小;
 * 然后再按此方法对这两部分数据分别进行快速排序;
 * 整个排序过程可以递归进行，以此达到整个数据变成有序序列;
 * 
 */

using System.Collections.Generic;

namespace SortConsole
{
    public class QuickSort
    {
        public static void Sort(List<int> tmpList,int tmpleft,int tmpright)
        {
            // only one element not need sort;
            if (tmpList == null || tmpList.Count <= 1 || tmpleft>=tmpList.Count||tmpright<0)
            {
                return;
            }

            int left = tmpleft;
            int right = tmpright;
            int key = tmpList[left];
            while(left<right)
            {
                // 依次遍历右边,当找到比当前key小的,将比key小的放在左边;
                while(tmpList[right]>=key&&right>left)
                {
                    --right;
                }

                // 将当前的放在左边;
                tmpList[left] = tmpList[right];
                
                // 依次遍历左边,当找到比当前key大的,将比key大的放在右边;
                while(tmpList[left]<=key&&left<right)
                {
                    ++left;
                }

                // 将当前比key大的放在右边;
                tmpList[right]=tmpList[left];
            }

            // 此时,左边都比右边的小;
            // 依次递归遍历剩下的左边和右边;
            // left=right;
            tmpList[left] = key;

            // 对左边进行快速排序;
            Sort(tmpList,tmpleft+1,tmpright);
            // 对右边进行快速排序;
            Sort(tmpList,tmpleft,tmpright-1);
        }
    }
}
