using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace LinqTutorial
{
    public static class StringHelper
    {
        public static string ChangeStringCase(this string stringInput)
        {
            if(stringInput.Length > 0)
            {
                char[] charArray = stringInput.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return stringInput;
        }
    }
}
