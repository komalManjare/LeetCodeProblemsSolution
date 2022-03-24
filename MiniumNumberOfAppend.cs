using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    public class MiniumNumberOfAppend
    {
        public static void Get(string origStr, int x_replace, int y_replace)
        {
            int count = 0;
            int org_str_length = origStr.Length;
            string cut_string;
            string final_str = origStr;

            for (int i = 0; i < org_str_length; i++)
            {
                cut_string = final_str.Substring(org_str_length - x_replace);
                final_str = final_str.Substring(0, org_str_length - x_replace);
                final_str = cut_string + final_str;
                count++;
                if (final_str.Equals(origStr))
                {
                    break;
                }
                cut_string = final_str.Substring(org_str_length - y_replace);
                final_str = final_str.Substring(0, org_str_length - y_replace);
                final_str = cut_string + final_str;
                count++;
                if (final_str.Equals(origStr))
                {
                    break;
                }
               
            }
            Console.WriteLine($"number of operations are : { count}");
        }
    }
}
