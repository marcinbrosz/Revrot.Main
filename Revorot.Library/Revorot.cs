using System;
using System.Collections.Generic;
using System.Linq;
/*
    The input is a string str of digits. Cut the string into chunks
    (a chunk here is a substring of the initial string) of size sz 
    (ignore the last chunk if its size is less than sz).

    If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2,
    reverse that chunk; otherwise rotate it to the left by one position. Put together these 
    modified chunks and return the result as a string.
*/
namespace Revorot.Library
{
    public class Revorot
    {
        public static string RevRot_Fun(string strng, int sz)
        {


            if (String.IsNullOrEmpty(strng) || sz <= 0 || sz > strng.Length)
                return String.Empty;

            return
                new String(
                    Enumerable.Range(0, strng.Length / sz)
                        .Select(i => strng.Substring(i * sz, sz))
                        .Select(
                            chunk =>
                                chunk.Sum(digit => (int)Math.Pow(int.Parse(digit.ToString()), 3)) % 2 == 0
                                    ? chunk.Reverse()
                                    : chunk.Skip(1).Concat(chunk.Take(1)))
                        .SelectMany(x => x)
                        .ToArray());

            /*
            if (sz <= 0 || !strng.Any() || sz> strng.Count())
            {
                return "";
            }
            else
            {
                List<List<string>> lista = new List<List<string>>();
                List<string> temp = new List<string>();
                int j = 0;
                double value = 0;

                for (int i = 0; i < strng.Length; i++)
                {


                    value += Convert.ToDouble( Math.Pow(Convert.ToDouble(strng[i].ToString()), 3.0));
                    temp.Add(strng[i].ToString());

                    j++;


                    if (j == sz)
                    {
                        j = 0;
                         
                         int len = temp.Count - 1;

                         if ((value / 2) % 2 > 0)
                         {
                             List<string> temp_t = temp.ToList();
                             temp[len] = temp_t[0];
                             for (int k = 0; k < temp.Count - 1; k++)
                             {

                                 temp[k] = temp_t[k + 1];

                             }
                         }
                         else
                         {
                             temp.Reverse();
                         }
                        lista.Add(temp.ToList());
                        temp.Clear();
                        value = 0;
                    }

                }

                string a = "";

                foreach (List<string> l in lista)
                {
                    a += string.Join("", l.ToArray());
                }


                return a;
            }*/
        }
    }
}
