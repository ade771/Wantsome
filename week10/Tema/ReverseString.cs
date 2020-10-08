using System;
using System.Collections.Generic;
using System.Text;

namespace TemaGeneric
{
    public class ReverseString
    {
        public void Reverse(char[] str)
        {
            int right = str.Length - 1;
            int left = 0;

            while (left < right)
            {
                if (!char.IsLetter(str[left]))
                    left++;
                else if (!char.IsLetter(str[right]))
                    right--;
                else
                {
                    char temporary = str[left];
                    str[left] = str[right];
                    str[right] = temporary;
                    left++;
                    right--;
                }
            }

        }
    }
}
