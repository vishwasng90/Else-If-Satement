using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 24;
            if(time<10)
            {
                Console.WriteLine("Good Morning");
            }
            else if(time<18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("Good evening");
                Console.ReadLine();
            }
        }
    }
}
