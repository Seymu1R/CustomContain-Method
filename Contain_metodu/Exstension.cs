using System;
using System.Collections.Generic;
using System.Text;

namespace Contain_metodu
{
    static class Exstension
    {
        public static void customContain(this string SearchItem, string FindItem)
        {
            
            string shema = string.Empty;
            bool result = false;

            for (int i = 0; i < SearchItem.Length; i++)
            {
                if ((i + FindItem.Length) > SearchItem.Length)
                {
                    break;
                }
                shema = SearchItem.Substring(i, FindItem.Length);
                if (shema.ToLower() == FindItem.ToLower())
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
