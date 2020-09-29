using System;
using System.Collections.Generic;
using System.Text;

namespace session1
{
    class StringUtility
    {
        public static string SummarizeText(string scentance)
        {
            string changed = "";
            for(int i=0; i < scentance.Length; i++)
            {
                if (i < 20){
                    changed =  changed + scentance[i];
                }else if (20 < i && i< 23){
                    changed = changed + '.';
                }else if(i > 23){
                    break;
                }
            }
            return changed;
        }
    }
}
