using System;

namespace GithubTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Github test. This line was added in Visual Studio.");
            Console.WriteLine("This line was added in Github.");
             
            Console.WriteLine($"Program written by:\n{SCO.GetName()}\n{User1.GetName()}\n{User2.GetName()}\n{User3.GetName()}");
        }
    }
}
