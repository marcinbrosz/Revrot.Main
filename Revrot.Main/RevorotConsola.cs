using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    The input is a string str of digits. Cut the string into chunks
    (a chunk here is a substring of the initial string) of size sz 
    (ignore the last chunk if its size is less than sz).

    If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2,
    reverse that chunk; otherwise rotate it to the left by one position. Put together these 
    modified chunks and return the result as a string.
*/
namespace Revrot.Main
{
    class RevorotConsola
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Revorot.Library.Revorot.RevRot_Fun("7700582115650484407780022837102095456241", 8));
           
            Console.Read();

        }
    }
}
