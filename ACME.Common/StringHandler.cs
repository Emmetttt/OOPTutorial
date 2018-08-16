using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        {
            // this extends the string type.
            // extension must reside in a static class.
            string result = string.Empty;

            if (!String.IsNullOrEmpty(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter) 
                        && !result.EndsWith(" ") 
                        && !String.IsNullOrEmpty(result))
                    {
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result;
        }
    }
}
