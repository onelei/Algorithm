using System;
using System.Collections.Generic;

namespace SortConsole
{
    public class SortBubble
    {    
        // from small to big;
        public static void Sort(List<int> tmpList)
        {
            // only one element not need sort;
            if (tmpList == null || tmpList.Count<=1)
            {
                return;
            }
            int length=tmpList.Count;
            int tmp;
            for (int i = 0; i < length;++i )
            {
                for (int j = i+1; j < length;++j )
                {
                    if(tmpList[j]<tmpList[i])
                    {
                        tmp = tmpList[j];
                        tmpList[j] = tmpList[i];
                        tmpList[i] = tmp;
                    }
                }
            }
        }

    }
}
