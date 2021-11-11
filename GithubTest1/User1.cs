using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest1
{
    class User1
    {
        public static string GetName()
        {
            string returnString = "123qq1 : Thats Me :3";
            return returnString;
        }

        public int Hashing(int state)
        {
            state ^= 2747636419;
            state *= 2654435769;
            state ^= state >> 16;
            state *= 2654435769;
            state ^= state >> 16;
            state *= 2654435769;
            return state;
        }
    }
}
