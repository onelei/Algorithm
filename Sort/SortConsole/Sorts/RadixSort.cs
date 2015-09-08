/*
 * 基数排序; 
 * 是按照低位先排序，然后收集；再按照高位排序，然后再收集；依次类推，直到最高位;
 * 有时候有些属性是有优先级顺序的，先按低优先级排序，再按高优先级排序;
 * 最后的次序就是高优先级高的在前，高优先级相同的低优先级高的在前;
 * 基数排序基于分别排序，分别收集，所以是稳定的;
 *
 */

using System.Collections.Generic;

namespace SortConsole
{
    public class RadixSort
    {    
        // from small to big;
        public static void Sort(List<int> tmpList)
        {
            // only one element not need sort;
            if (tmpList == null || tmpList.Count<=1)
            {
                return;
            }
          
        }

    }
}
