using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);
        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach(Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
        public class SimpleMath
        {
            public int Add(int x, int y) => x + y;
            public int Substract(int x, int y) => x - y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");
            SimpleMath m = new SimpleMath();

            BinaryOp b = new BinaryOp(m.Add);
            Console.WriteLine("10 + 10 is {0}", b(10, 10));
            DisplayDelegateInfo(b);
        }
    }
}
