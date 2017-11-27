using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Revorot.Test
{
    [TestClass]
    public class UnitTest1
    {
        private static Random rnd = new Random();

        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Testing RevRot");
            testing(Revorot.Library.Revorot.RevRot_Fun("1234", 0), "");
            testing(Revorot.Library.Revorot.RevRot_Fun("", 0), "");
            testing(Revorot.Library.Revorot.RevRot_Fun("1234", 5), "");
            String s = "733049910872815764";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 5), "330479108928157");
            s = "73304991087281576455176044327690580265896";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 8), "1994033775182780067155464327690480265895");
            s = "73304991087281576455176044327690580265896896028";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 8), "1994033775182780067155464327690480265895");
            s = "73304991087281576455176044327690580265896896028126182265439";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 11), "3304991087781576455172509672344060265896896862281621820");
            s = "73304991087281576455176044327690580265896896028126182265439441215340989";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 14), "1827801994033776455176044325690580265896875622816218206939441215340984");

            s = "563000655734469485";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 4), "0365065073456944");
            s = "56300065573446948588855";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 3), "365000556437694854888");
            s = "56300065573446948588855200928875449742090";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 6), "000365437556584964255888092880794457");
            s = "56300065573446948588855200928875449742090827299285754137212";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 11), "3755600036546948588854457882900257280902479499285754132");
            s = "56300065573446948588855200928875449742090827299285754137212673841954794395427";
            testing(Revorot.Library.Revorot.RevRot_Fun(s, 10), "6300065575446948588355200928885449742097582992728062127314573841954797");
        }

        //-----------------------
        private static string[] SplitEqualSol(string str, int sz)
        {
            return Enumerable.Range(0, str.Length / sz)
                .Select(i => str.Substring(i * sz, sz)).ToArray();
        }
        private static string RevRotSol(string strng, int sz)
        {
            if ((sz <= 0) || (strng.Equals("")) || (sz > strng.Length)) return "";
            string[] arr = SplitEqualSol(strng, sz);
            string[] arrnew = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                char[] u = arr[i].ToCharArray();
                int sm = 0;
                for (int j = 0; j < u.Length; j++)
                {
                    int k = (int)Char.GetNumericValue(u[j]);
                    sm += k * k * k;
                }
                if (sm % 2 == 0)
                {
                    Array.Reverse(u);
                    arrnew[i] = new string(u);
                }
                else arrnew[i] = arr[i].Substring(1) + arr[i][0];
            }
            return String.Join("", arrnew);
        }
        //-----------------------
        [TestMethod]
        public void RandomTest()
        {
            Console.WriteLine("Random Tests");
            int i = 0; string s = "";
            while (i < 100)
            {
                int v = rnd.Next(1, 10);
                int j = 0;
                while (j <= v)
                {
                    int k = rnd.Next(10000, 10000000);
                    s += k;
                    j++;
                }
                int n = rnd.Next(3, Math.Max(s.Length / 3, 5));
                testing(Revorot.Library.Revorot.RevRot_Fun(s, n), RevRotSol(s, n));
                i++;
            }

        }
    }
}
