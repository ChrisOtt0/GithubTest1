using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest1
{
    class SCO
    {
        public static string GetName()
        {
            string returnString = "ChrisOtt0 OwO";
            return returnString;
        }

        public static string Add(int a, int b)
        {
            string lol1 = Convert.ToString(a);
            string lol2 = Convert.ToString(b);

            string lolCombined = lol1 + lol2;

            return lolCombined;
        }

        public static void MergeIssues()
        {
            string lol = Add(6, 9);
            Console.WriteLine(lol);
        }
    }
}
