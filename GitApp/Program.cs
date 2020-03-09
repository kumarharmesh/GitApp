using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{

    class Program
    {
        static void Main(string[] args)
        {  
            Action<string> printf = Console.WriteLine;
            printf("Project Created");
            printf(DateClass.GetDate());
            Console.WriteLine("Project Created");
            Console.WriteLine(DateClass.GetDate());
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
        public static bool Compare(int x, int y) => x > y;
    }
    class Emp
    {
        public string Name{get;set;}   
        public byte Age{get;set;}   
    }
}
