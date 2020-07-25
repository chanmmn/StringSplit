using System;
using System.Collections.Generic;

namespace LibNetStandard
{
    public class StringUtil
    {
        public static List<string> Split(List<string> lst, string str, string indexof)
        {
            int index = str.IndexOf(indexof);
            int begin = index + indexof.Length;
            int end = str.Length - (index + indexof.Length);
            if (index == -1)
            {
                lst.Add(str);
                return lst;
            }
            else
            {
                string strNew = str.Substring(0, index);
                lst.Add(strNew);
                //str = strNew + Split(lst, str.Substring(begin,end), indexof);
                Split(lst, str.Substring(begin, end), indexof);
                //return str;
                return lst;
            }
        }
    }
}
