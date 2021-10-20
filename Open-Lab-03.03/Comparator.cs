using System;

namespace Open_Lab_03._03
{
    public class Comparator
    {
        public bool CompareCharactersCount(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            
            if (length1 == length2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
