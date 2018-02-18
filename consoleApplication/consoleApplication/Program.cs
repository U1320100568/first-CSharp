using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(10);
            s.Push(100);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            int i=1,j=2;
            Swap(ref i,ref j);
            Console.WriteLine(i);
            Console.WriteLine(i.ToString()+" "+j.ToString());

            var names = new List<String> { "aa", "bb", "cc" };
            foreach (var name in names) { 
                Console.WriteLine(name);
            }

            Console.WriteLine("enter your name:");
            var user=Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine("\nHello,"+user+", on "+ date);
            
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

    
}
