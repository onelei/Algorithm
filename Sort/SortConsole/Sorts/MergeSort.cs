/*
 * 归并排序;
 * 归并（Merge）排序法是将两个（或两个以上）有序表合并成一个新的有序表;
 * 即把待排序序列分为若干个子序列，每个子序列是有序的;
 * 然后再把有序子序列合并为整体有序序列;
 *  
 */

using System.Collections.Generic;

namespace SortConsole
{
    public class MergeSort
    {
        public static void Sort(List<int> tmpList,int low,int high)
        {
            // only one element not need sort;
            if (tmpList == null || tmpList.Count <= 1)
            {
                return;
            }

            // 用分治法对tmpList[low...high]进行二路归并排序;
            int mid;
            if(low<high)
            {
                // 区间长度大于1;
                // 分解;
                mid=(low+high)/2;
                // 递归的对tmpList[low...mid]排序;
                Sort(tmpList, low, mid);
                // 递归的对tmpList[mid+1...high]排序;
                Sort(tmpList,mid+1,high);
                // 组合,将两个有序区归并为一个有序区;
                Merge(tmpList,low,mid,high);
            }
           
        }

        // 归并;
        static void Merge(List<int> list,int low,int mid,int high)
        {
            // 将两个有序的子序列list[low...mid]和list[mid+1...high];
            // 归并成一个有序的序列list[low...high];
            int i = low;
            int j = mid + 1;
            int p=0;
            List<int> tmpList = new List<int>();
            // 将两个子序列中的最小者取出,放入tmpList中;
            while(i<=mid&&j<=high)
            {
                tmpList.Add((list[i]<=list[j])?list[i++]:list[j++]);
            }
            // 若第一个序列非空,则复制剩余的纪录到tmpList中;
            while(i<=mid)
            {
                tmpList.Add(list[i++]);
            }
            // 若第二个序列非空,则复制剩余的纪录到tmpList中;
            while(j<=high) 
            {
                tmpList.Add(list[j++]);
            }

            // 归并后将结果复制回list[low...high];
            for (p = 0, i = low; i < high;p++,i++)
            {
                list[i]=tmpList[p];
            }
        }
    }
}
